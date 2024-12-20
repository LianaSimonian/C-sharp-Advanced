﻿using System;

namespace Delegates
{
    internal class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
     public void Process(string path,PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();

        }
    }
}
