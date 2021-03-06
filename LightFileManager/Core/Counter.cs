using System;
using System.Collections;
using System.IO;

namespace LightFileManager.Core
{
    public class Counter
    {
        public int FilesCount { get; private set; }
        public int DirectoriesCount { get; private set; }
        public double FolderSize { get; private set; }

        public Counter()
        {
            FilesCount = DirectoriesCount = 0;
        }

        public void Clear()
        {
            FilesCount = DirectoriesCount = 0;
        }

        public void Count(DirectoryInfo dir)
        {
            try
            {
                ArrayList files = new ArrayList();
                files.AddRange(dir.GetDirectories());
                files.AddRange(dir.GetFiles());

                foreach (var file in files)
                {
                    if (file is DirectoryInfo)
                    {
                        DirectoriesCount++;
                        Count(file as DirectoryInfo);
                    }
                    else
                    {
                        FilesCount++;
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void CountSize(DirectoryInfo dir)
        {
            try
            {
                ArrayList files = new ArrayList();
                files.AddRange(dir.GetDirectories());
                files.AddRange(dir.GetFiles());

                foreach (var file in files)
                {
                    if (file is DirectoryInfo)
                    {
                        CountSize(file as DirectoryInfo);
                    }
                    else
                    {
                        FolderSize += ((FileInfo) file).Length / Math.Pow(1024, 2);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
