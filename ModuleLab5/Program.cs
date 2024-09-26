using System; // includes reading & writing to the console

namespace ZooLab{// allow u to create a conatiner that can hold 1 or more classes
    class Program {
        static void Main(string[] args) {
            //static doesn't create any new | void == doesnt return a value| Main is case sensitive
            //promt the user to enter a number of animals
            Console.WriteLine("Enter the number of animals in the zoo: ");
            int animalCount = int.Parse(Console.ReadLine());

            //Decalre & initialize an array to hold animals
            string[] animals = new string[animalCount];//You use the animal count vari
            // to specify the size of the array

            //populate the array with user defined animal names
            for(int i = 0; i < animalCount; i++){
                //prompt user to enter animal name
                Console.WriteLine($"Enter animal name {i + 1}: ");

                //read the animal name and enter it into the array
                animals[i] = Console.ReadLine();
            }//end of loop
            //display list of animals for each loop
            Console.WriteLine("List of Zoo Animals: ");
            foreach (string animal in animals){
                Console.WriteLine(animal);
            }//end of for each loop
    
        }//end of main method
    }//end class
}//end namespace