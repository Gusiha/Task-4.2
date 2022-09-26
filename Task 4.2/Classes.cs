﻿namespace Task
{
    internal class Goods
    {

        public string Name { get; set; }
        public int Val { get; set; }


        public Goods(string Name, int Val)
        {
            this.Name = Name;
            this.Val = Val;
        }

    }

    internal class Shop
    {
        public Goods[] ArrEl;

        public Goods this[int index]
        {
            get
            {
                if (index >= 0 && index < ArrEl.Length)
                {
                    return ArrEl[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public Goods this[string name]
        {
            get
            {
                foreach (var item in ArrEl)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }


                }
                return null;

            }

        }

        public Shop(params Goods[] arr )
        {
            ArrEl = arr;
        }

    }
}