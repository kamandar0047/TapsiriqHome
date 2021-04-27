using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tapsiriq;

namespace tapsiriq
{
    class guns
    {

        public int TotalPistolCount { get; }
        public int CurrentPistolCount { get; }
        public float PistolType { get; }

      public void Shoot()
        { }
        public void Reload()
        { }
    }
    class P92 : guns { 
    public int ZoomLevel { get; set; }





    }
   }
class M416 : guns, IZoomLevel, ChangeMode
{
    public int ZoomLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ShootMode Shotmode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void changeMode()
    {
        throw new NotImplementedException();
    }

    public void ZoomIn()
    {
        throw new NotImplementedException();
    }

    public void ZoomOut()
    {
        throw new NotImplementedException();
    }

    private class Mk14 : guns, IZoomLevel, ChangeMode
    {
        public int ZoomLevel { get; set ; }
        public ShootMode Shotmode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void changeMode()
        {
            throw new NotImplementedException();
        }

        public void ZoomIn()
        {
            Console.WriteLine("Zoomed in");
        }

        public void ZoomOut()
        {
            Console.WriteLine("Zoomed out");
        }
    }
}