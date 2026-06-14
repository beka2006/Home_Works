using System;
using System.IO;

// N1 ამოცანა 
namespace HomeWorks
{
    abstract class FileWorker
    {
        private int MaxStorage;
        protected abstract string FilePath { get; set; }

        public FileWorker(int maxStorage)
        {
            MaxStorage = maxStorage;
        }

        public virtual string Read()
        {
            if (!File.Exists(FilePath))
            {
                return "File not found";
            }

            string content = File.ReadAllText(FilePath);
            Console.WriteLine($"I can read file with max storage {MaxStorage}");
            return content;
        }

        public virtual void Write(string content)
        {
            if (content.Length > MaxStorage)
            {
                Console.WriteLine("Storage is full");
                return;
            }
            File.WriteAllText(FilePath, content);
            Console.WriteLine($"I Can write to txt file with max storage {MaxStorage}");
        }

        public void Edit(string newContent)
        {
            if (newContent.Length > MaxStorage)
            {
                Console.WriteLine("Content exceeds max storage limit.");
                return;
            }
            File.WriteAllText(FilePath, newContent);
            Console.WriteLine($"I can edit file with max storage {MaxStorage}");
        }

        public void Delete()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                Console.WriteLine($"I can delete file {FilePath}");
            }
        }
    }

    class TextFileWorker : FileWorker
    {
        protected override string FilePath { get; set; }

        public TextFileWorker(string filePath, int maxStorage) : base(maxStorage)
        {
            FilePath = filePath;
        }
    }
}