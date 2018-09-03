using System;

namespace CloudyDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's a Cloudy Day!");
        
            Town mt = new Town();
            Town[5] myTowns;
            
            for(int i=0; i<myTowns.Length; i++)
            {
                myTowns[i] = new Town();
            }
        }
    }
    
    //[access modifier] - [class] - [identifier]
    public class Town
    {
        private int population;
        private int location;
        
        public void SetLocation(int loc)
        {
            this.location = loc;
        }
        public void SetPopulation(int pop)
        {
            this.population = pop;
        }
        public int GetLocation()
        {
            return this.location;
        }
        public int GetPopulation()
        {
            return this.population;
        }        
    // Fields, properties, methods and events go here...
    }
    
    public class Cloud
    {
        private int location;
        private int size;
        
        public void SetLocation(int loc)
        {
            this.location = loc;
        }
        public void SetSize(int s)
        {
            this.size = s;
        }
        
        public int GetLocation()
        {
            return this.location;
        }
        public int GetSize()
        {
            return this.size;
        }
    }
}
