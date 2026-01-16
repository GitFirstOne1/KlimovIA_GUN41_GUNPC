namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };

            string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            int[,] array3 = new int[3, 3]
            {
                { (int)Math.Pow(2,1),(int)Math.Pow(3,1),(int)Math.Pow(4,1)},
                { (int)Math.Pow(2,2),(int)Math.Pow(3,2),(int)Math.Pow(4,2)},
                { (int)Math.Pow(2,3),(int)Math.Pow(3,3),(int)Math.Pow(4,3)},
            };

            double[][] array4 = new double[3][];
            array4[0] = new double[5] { 1, 2, 3, 4, 5 };
            array4[1] = new double[2] { Math.E, Math.PI };
            array4[2] = new double[4] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            int[] array51 = { 1, 2, 3, 4, 5 };
            int[] array52 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array51, 0, array52, 0, 3);

            Array.Resize(ref array51, 10);
            
        }
        }
    }





                
        
    

            
            




    
