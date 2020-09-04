using System;

namespace OOP {
    class Media { 

        //private: Only accessible within the class
        //protected: Only accessible within the class and within sub-classes
        //public: Accessible to all
           protected string title;
           private double length;

            public Media(string title) {
                this.title = title;
            }

           public virtual void Play() {
               Console.WriteLine("Now playing " + title);
           }
    }   
}