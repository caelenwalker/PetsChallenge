using System;
using System.IO;

namespace Pets_Challenge {
    public class Pet {
        public string type = "";
        public string name = "";
        public string owner = "";
        public double weight;

        public Pet(string typeName, string petName, string ownerName, double petWeight) {
            type = typeName;
            name = petName;
            owner = ownerName;
            weight = petWeight; 
        }

        public string getTag() {
            return "If lost, call " + owner;
        }
    }
}