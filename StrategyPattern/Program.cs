using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TerrierPuppy myPuppy = new TerrierPuppy();

            myPuppy.PerformPlay();

            TugOfWarPlay myPlayBehavior = new TugOfWarPlay();
            myPuppy.SetPlayBehavior(myPlayBehavior);
            myPuppy.PerformPlay();
            Console.ReadKey();
        }
    }
    public interface IPlayBehavior
    {
        void Play();
    }

    public class FetchPlay : IPlayBehavior
    {
        public void Play()
        {
            Console.WriteLine("Puppy plays fetch!");
        }
    }

    public class TugOfWarPlay : IPlayBehavior
    {
        public void Play()
        {
            Console.WriteLine("Puppy plays tug of war!");
        }
    }

    public abstract class Puppy
    {
        protected IPlayBehavior playBehavior;

        public Puppy()
        {

        }

        public void SetPlayBehavior(IPlayBehavior pb)
        {
            playBehavior = pb;
        }

        public void PerformPlay()
        {
            playBehavior.Play();
        }
    }

    public class TerrierPuppy : Puppy
    {      
        public TerrierPuppy()
        {
            playBehavior = new FetchPlay();
        }
    }

}
