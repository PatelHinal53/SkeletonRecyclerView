using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkeletonEx
{
    class Friends
    {
        public Friends(int id, string name, string description)
        {
            PhotoId = id;
            Fname = name;
            Fdescription = description;

        }

        public int PhotoId { get; }
        public string Fname { get; }
        public string Fdescription { get; }
    }
    class Details
    {

        static Friends[] frnd = {

            new Friends(Resource.Drawable.black_rose,"Ross Black","The Black ross for"),
            new Friends(Resource.Drawable.blue_rose,"Ross Blue","The Blue ross for"),
            new Friends(Resource.Drawable.darkblue_rose,"Ross DarkBlue","The DarkBlue ross for"),
            new Friends(Resource.Drawable.pink_rose,"Ross Pink","The Pink ross for"),
            new Friends(Resource.Drawable.red_rose,"Ross Red","The Red ross for"),
            new Friends(Resource.Drawable.white_rose,"Ross White","The White ross for"),
            new Friends(Resource.Drawable.yellow_rose,"Ross Yellow","The Yellow ross for"),
            new Friends(Resource.Drawable.black_rose,"Ross Black","The Black ross for"),
            new Friends(Resource.Drawable.blue_rose,"Ross Blue","The Blue ross for"),
            new Friends(Resource.Drawable.darkblue_rose,"Ross DarkBlue","The DarkBlue ross for"),
            new Friends(Resource.Drawable.pink_rose,"Ross Pink","The Pink ross for"),
            new Friends(Resource.Drawable.red_rose,"Ross Red","The Red ross for"),
            new Friends(Resource.Drawable.white_rose,"Ross White","The White ross for"),
            new Friends(Resource.Drawable.yellow_rose,"Ross Yellow","The Yellow ross for"),
            new Friends(Resource.Drawable.black_rose,"Ross Black","The Black ross for"),
            new Friends(Resource.Drawable.blue_rose,"Ross Blue","The Blue ross for"),
            new Friends(Resource.Drawable.darkblue_rose,"Ross DarkBlue","The DarkBlue ross for"),
            new Friends(Resource.Drawable.pink_rose,"Ross Pink","The Pink ross for"),
            new Friends(Resource.Drawable.red_rose,"Ross Red","The Red ross for"),
            new Friends(Resource.Drawable.white_rose,"Ross White","The White ross for"),
            new Friends(Resource.Drawable.yellow_rose,"Ross Yellow","The Yellow ross for"),
            };

        private Friends[] mfrnd;

        Random random;

        public Details()
        {
            mfrnd = frnd;
            random = new Random();
        }

        public int NumbFriends
        {

            get { return mfrnd.Length; }
        }

        public Friends this[int i]
        {
            get { return mfrnd[i]; }
        }

        public int RandomSwap()
        {
            Friends tempfrnd = mfrnd[0];

            int mrandom = random.Next(1, mfrnd.Length);

            mfrnd[0] = mfrnd[mrandom];
            mfrnd[mrandom] = tempfrnd;

            return mrandom;
        }

        public void Suffle()
        {
            for (int i = 0; i < mfrnd.Length; i++)
            {
                Friends tempfrnd = mfrnd[i];


                int mrandom = random.Next(1, mfrnd.Length);

                mfrnd[i] = mfrnd[mrandom];
                mfrnd[mrandom] = tempfrnd;
            }

        }
    }
}