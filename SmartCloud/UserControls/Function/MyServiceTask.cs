﻿using SmartCloud.Constants;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartCloud.UserControls.Function
{
    public class MyServiceTask
    {
        /// <summary>
        /// 总文件路径
        /// </summary>
        private string FilePath;

        /// <summary>
        /// (文件读取）线程队列
        /// </summary>
        public ConcurrentQueue<string> FileReadQueue;
        /// <summary>
        ///（文件服务）线程队列
        /// </summary>
        public ConcurrentQueue<string> FileServiceQueue;

        public MyServiceTask()
        {
            // 实例化线程队列
            FileServiceQueue = new ConcurrentQueue<string>();
        }

        public void Start(string filePath, ConcurrentQueue<string> queue)
        {
            this.FilePath = filePath;
            this.FileReadQueue = queue;
            Thread t = new Thread(new ThreadStart(ExecuteManager));
            t.Start();
        }

        /// <summary>
        /// 执行管理方法
        /// </summary>
        private void ExecuteManager()
        {
            // 用于存储符合条件的文件及文件夹的全路径名
            List<string> filesList = new List<string>();
            // 获取文件全路径名
            this.GetFileFullNameToList(filesList, this.FilePath);
            // 添加停止标识
            this.FileReadQueue.Enqueue(CommonConstant.QUEUE_STOP_FLAG);
            this.FileServiceQueue.Enqueue(CommonConstant.QUEUE_STOP_FLAG);
        }

        /// <summary>
        /// （递归）获取路径中所有的文件全路径名
        /// </summary>
        /// <param name="filesList">存储文件全路径名</param>
        /// <param name="filePath">文件夹路径</param>
        private void GetFileFullNameToList(List<string> filesList, string filePath)
        {
            DirectoryInfo directorys = new DirectoryInfo(@filePath);
            // 获取对当前路径中的文件并储存
            FileInfo[] files = directorys.GetFiles();
            if (files != null && files.Length > 0)
            {
                foreach (FileInfo file in files)
                {
                    filesList.Add(file.FullName);
                    this.FileReadQueue.Enqueue(file.FullName);
                    this.FileServiceQueue.Enqueue(file.FullName);
                }
            }
            // 判断当前路径是否子文件夹，如果有则储存文件夹路径并递归获取其中的文件
            DirectoryInfo[] directories = directorys.GetDirectories();
            if (directories != null && directories.Length > 0)
            {
                foreach (DirectoryInfo directory in directories)
                {
                    filesList.Add(directory.FullName);
                    this.FileReadQueue.Enqueue(directory.FullName);
                    this.FileServiceQueue.Enqueue(directory.FullName);
                    this.GetFileFullNameToList(filesList, directory.FullName);
                }
            }
        }
    }
}
