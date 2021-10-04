using System;

namespace LiskovSubstitution
{


    interface ICamera
    {
        void Camera();
    }
    interface IFingerPrint
    {
        void FingerPrint();
    }
    class Samsung : ICamera, IFingerPrint
    {
        public void FingerPrint()
        {
            Console.WriteLine("Samsung Finger Print Worked");
        }
        public  void Camera()
        {
            Console.WriteLine("Samsung Camera");
        }
    }
    class Nokia : ICamera
    {
        public  void Camera()
        {
            Console.WriteLine("Nokia Camera");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
