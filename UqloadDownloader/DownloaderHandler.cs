using System;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UqloadDownloader
{
    class DownloadHandler // This class is used to manage and handle download
    {
        WebClient new_client = new WebClient();
        string _ext = "mp4";

        long max_dl_size = 0;
        long curr_dl_size = 0;

        bool download_finished = false;
        
        ListView _listview;
        ListViewItem _item = new ListViewItem();

        public DownloadHandler(string DownloadURL, ListView listview, string file_title = null, string output_folder = null)
        {
            bool can_download = false;
            int download_type = 1;
            string good_url = "";
            _listview = listview;

            new_client.DownloadFileCompleted += OnDownloadCompleted;
            new_client.DownloadProgressChanged += OnDownloadProgress;

            try
            {
                if(!Regex.IsMatch(DownloadURL, "^https?://"))
                throw new Exception("Invalid Url Or Error !");
                
                if(Regex.IsMatch(DownloadURL, @"^https?://uqload\.(com|io)/embed\-"))
                {
                    string page_str = new_client.DownloadString(DownloadURL);
                    TextBox local_tb = new TextBox();

                    local_tb.Text = page_str;

                    if(string.IsNullOrEmpty(file_title))
                    {
                        var rmatch = Regex.Match(page_str, "chromecast:\\s*{\\s*media:\\s*{title:\\s*\"([^\"]*)\"}", RegexOptions.IgnoreCase);

                        if(rmatch.Success)
                        file_title = rmatch.Groups[1].Value;
                    }

                    foreach (string tb_line in local_tb.Lines)
                    {
                        string base_beg = "sources: [" + '"' + "https://";
                        string base_beg2 = "sources: [" + '"';
                        string base_end = '"' + "],";

                        if (tb_line.Contains(base_beg))
                        {
                            good_url = tb_line.Replace(base_beg2, "").Replace(base_end, "").Trim();
                            break;
                        }
                    }

                    download_type = 1;
                    can_download = true;
                }
                else if(Regex.IsMatch(DownloadURL, "\\."+Regex.Escape(_ext)+"$", RegexOptions.IgnoreCase))
                {
                    download_type = 2;
                    can_download = true;
                }
            }
            catch
            {
                MessageBox.Show("Can't Download\nInvalid Url Or Error", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (can_download)
            {
                _item.Text = file_title+"."+_ext;
                _item.SubItems.AddRange(new string[] {
                    "0%", "0 MB/s", "", "Waiting to download"
                });
                listview.Invoke(new MethodInvoker(delegate { listview.Items.Add(_item); }));

                ThreadPool.QueueUserWorkItem(ETA_Calculator_Thread);

                if (download_type == 1)
                new_client.Headers.Add("Referer", DownloadURL);
                else
                new_client.Headers.Remove("Referer");

                new_client.DownloadFileAsync(new Uri(download_type == 1 ? good_url : DownloadURL), output_folder + "\\" + file_title + "."+_ext);
            };
        }

        public void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            download_finished = true;
        }

        public void OnDownloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            max_dl_size = e.TotalBytesToReceive;
            curr_dl_size = e.BytesReceived;

            _item.SubItems[1].Text = e.ProgressPercentage+"%";
            _item.SubItems[4].Text = "Downloading";
        }

        public void ETA_Calculator_Thread(Object stateInfo)
        {
            // Formula : T = D / S
            // T = Time; D = Distance; S = Speed;

            int dl_speed = 0; // In KB
            string good_speed = "";

            long diff_1 = 0;
            long diff_2 = 0;
            long final_diff = 0;

            long eta_time = 0;

            while(true)
            {
                diff_1 = (curr_dl_size);

                Thread.Sleep(1000);

                diff_2 = (curr_dl_size);

                final_diff = diff_2 - diff_1;
                dl_speed = (int)(final_diff / 1000);

                if(dl_speed > 0)
                eta_time = (((max_dl_size - curr_dl_size) / 1000) / dl_speed);

                DateTime eta_converted = new DateTime();
                eta_converted = eta_converted.AddSeconds(eta_time);

                string final_time = "";

                if(eta_converted.Hour > 0)
                {
                    string end_h = "";
                    string end_m = "";

                    if (eta_converted.Hour > 1)
                    end_h = "s";

                    if (eta_converted.Minute > 1)
                    end_m = "s";

                    final_time = (eta_converted.Hour.ToString() + " Hour" + end_h + " ") + (eta_converted.Minute.ToString() + " Minute" + end_m);
                }
                else if(eta_converted.Minute > 0)
                {
                    string end_m = "";
                    string end_s = "";

                    if (eta_converted.Minute > 1)
                    end_m = "s";

                    if (eta_converted.Second > 1)
                    end_s = "s";

                    final_time = (eta_converted.Minute.ToString() + " Minute" + end_m + " ") + (eta_converted.Second.ToString() + " Second" + end_s);
                }
                else
                {
                    string end_s = "";

                    if (eta_converted.Second > 1)
                    end_s = "s";

                    final_time = (eta_converted.Second.ToString() + " Second" + end_s);
                }

                good_speed = dl_speed >= 1000 ? ((dl_speed / 1000).ToString()) + " MB/s" : dl_speed.ToString() + " KB/s";

                if(!download_finished)
                _listview.Invoke(new MethodInvoker(delegate {
                    _item.SubItems[2].Text = good_speed;
                    _item.SubItems[3].Text = final_time;
                }));
                else
                {
                    Thread.Sleep(500);

                    _listview.Invoke(new MethodInvoker(delegate {
                        _item.SubItems[1].Text = "";
                        _item.SubItems[2].Text = "";
                        _item.SubItems[3].Text = "";
                        _item.SubItems[4].Text = "Finished";
                    }));
                    break;
                }
            }
        }
    }
}
