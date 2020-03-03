using System;
using System.IO;

namespace Pets_Challenge {
    public class Cat : Pet {
        public Cat(string petName, string ownerName, double petWeight)
         : base("cat", petName, ownerName, petWeight) {
            name = petName;
            owner = ownerName;
            weight = petWeight; 
        }

        public string meow(int count) {
            string meows = "";
            for(int i = 0; i <= count - 1; i++) {
                meows += "Meow. ";
            }
            return meows;
        }
    }
}