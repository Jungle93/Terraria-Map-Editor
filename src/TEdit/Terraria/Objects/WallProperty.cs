﻿using System.Windows.Media;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;

namespace TEdit.Terraria.Objects
{
    public class WallProperty : ObservableObject, ITile
    {
        private Color _color;
        private int _id;
        private string _name;

        public WallProperty()
        {
            _color = Colors.Magenta;
            _id = -1;
            _name = "UNKNOWN";
        }

        public override string ToString() => Name;


        public WallProperty(int id, string name, Color color)
        {
            _color = color;
            _id = id;
            _name = name;
        }

        public Color Color
        {
            get { return _color; }
            set { Set(nameof(Color), ref _color, value); }
        }

        public int Id
        {
            get { return _id; }
            set { Set(nameof(Id), ref _id, value); }
        }

        public string Name
        {
            get { return _name; }
            set { Set(nameof(Name), ref _name, value); }
        }

        private WriteableBitmap _image;
        public WriteableBitmap Image
        {
            get { return _image; }
            set { Set(nameof(Image), ref _image, value); }
        }
    }
}