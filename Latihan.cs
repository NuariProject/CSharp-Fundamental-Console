using System;

// the class
// parent
    class Latihan1{
        protected internal string brand; // field
        public string car; // field
        // Polymorphism
        public virtual void BeliMobil(){ // use virtual
            Console.WriteLine("Beli Mobil CRV");
        }
        // contructor
        public Latihan1(){
            brand = "Honda";
            car = "CRV";
        }
    }

// the class
    class latihan2 : Latihan1{ // Derived class child
        // encapsulation 
        // you must have 1 field private and 1 property
        protected string bikePri; // field
        // Polymorphism
        public override void BeliMobil(){ // use override
            Console.WriteLine("Beli Motor NMax dan Mobil "
            +car);
        }

        public string Bike 
        {
            get{return bikePri;} // method
            set{bikePri = value;} // method
        } // property

        // constructor
        public latihan2(){
            brand = "Yamaha";
            bikePri = "N Max";
        }
    }