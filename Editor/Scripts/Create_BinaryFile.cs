using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace skfksky1004.DevKit
{
    public class Create_BinaryFile : Editor
    {
        private const string SavePath = "Assets/Resources/BinaryFile/{0}.binary";

        [MenuItem("Assets/Table/Create_BinaryTable")]
        public static void Create()
        {
            if (Selection.objects.Length <= 0) return;

            foreach (var obj in Selection.objects)
            {
                var textAsset = obj as TextAsset;
                if (textAsset is null)
                    return;

                var path = string.Format(SavePath, textAsset.name);
                if (File.Exists(path)) File.Delete(path);

                try
                {
                    using (var fs = new FileStream(path, FileMode.Create))
                    {
                        using (var bw = new BinaryWriter(fs))
                        {
                            bw.Write(textAsset.text);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            Debug.Log("���̳ʸ� ���� ���� ��~!");
        }
    }
}