using SmartCloud.Constants;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartCloud.UserControls.Function
{
    public class FileServer
    {
        /// <summary>
        ///（文件服务）线程队列
        /// </summary>
        public ConcurrentQueue<string> FileServiceQueue;

        public FileServer(ConcurrentQueue<string> queue)
        {
            this.FileServiceQueue = queue;
        }

        public void Start()
        {
            Thread t = new Thread(new ThreadStart(ExecuteManager));
            t.Start();
        }

        /// <summary>
        /// 执行管理方法
        /// </summary>
        private void ExecuteManager()
        {
            // 用于存文件及文件夹的全路径名
            List<string> filesList = new List<string>();
            // 从队列中获取文件信息
            GetFiles(filesList);


        }

        private void StartServer()
        {

            IPAddress[] ipAddress = Dns.GetHostAddresses("");
            IPAddress ip = ipAddress[3];

            TcpListener tcpListener = new TcpListener(ip, 0);
            tcpListener.Start();

            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                if (tcpClient != null)
                {
                    NetworkStream nwStream = tcpClient.GetStream();
                }

            }

        }

        private void GetFiles(List<string> filesList)
        {
            bool processControl = true;// 循环控制
            while (processControl)
            {
                if (this.FileServiceQueue.IsEmpty)
                    continue;
                // 从线程队列中获取信息
                string infoStr = "";
                bool successFlag = this.FileServiceQueue.TryDequeue(out infoStr);
                if (successFlag)
                {
                    // 是否未结束
                    if (!CommonConstant.QUEUE_STOP_FLAG.Equals(infoStr))
                        filesList.Add(infoStr);
                    else
                        processControl = false;
                }
            }
        }

    }
}
