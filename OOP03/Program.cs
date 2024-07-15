using OODemo;
using OODemo.Binding;

namespace OOP03
{
    internal class Program
    {

        public static void ProcessEmp(Employee emp) 
        {
            if(emp is not null) 
            {
                emp.GetEmployeeType();
                emp.GetEmpData();
            }
        }

        static void Main(string[] args)
        {
            #region RelationShip Between Classes
            //Assosiation RelationShip
            #region Assossiation RelationShip
            /*
             * there is two types of assosiation relationship 
             * 1 - Assosiation Composition
             * if we have a order item contain a product 
             * so order item must contain a proudct this is called Assosiation Composition
             * 
             * 2 - Asosiation Aggregation
             * if we have a room full of chairs 
             * if we remove chairs the room still founded 
             * 
             * 
             */
            #endregion


            #endregion

            #region Method Overloading
            //CS1 c = new CS1();
            //c.Sum(10, 10);
            //c.Sum(10.2, 10);
            #endregion

            #region Method Overriding
            //BaseClass b = new BaseClass();
            //b.Walk(); //Walk from the base class


            //ChildClass c = new ChildClass();
            //c.Walk(); // walk from the child class

            //We assign refernce from the parent class to the child class object
            //BaseClass b1 = new ChildClass();
            /*b1.Walk(); *///will call the parent class walk but why?
                           //in this case we get the walk based on the parent class because in this case we walk based on the reference not the objct
                           //but logicly this is not right becase we need to walk like a child class not base class why?
                           //because base class has walk methdo right but we cant describe he would walk so we need to tell 
                           //the compiler when we create object from child class and refere using parent class we we need to get the functions
                           //in the object not reference 

            //We need to tell the parent class that the walk function should used by the class that inherit from you 
            //we need to make it virtual

            //BaseClass b1 = new ChildClass();
            //b1.Walk();





            #endregion

            #region Binding
            Parent p = new Child();
            p.A = 10; //Valid
            //p.B = 20; //Invalid

            //Static Binding (Early Binding)
            //Compiler will Compile based on Parent class (reference) not object
            p.Walk();

            //Dynamic Binding(Late Binding)
            //Compiler will compile based on object class Not reference
            p.Move();


            #region Ex01
            //We create process Emp function take Employee Parent so we can pass to it parent object
            //or any class inherit from it 
            FullTimeEmployee emp = new FullTimeEmployee(10, "Ebrahem", 26, 3000);
            ProcessEmp(emp);

            PartTimeEmp partEmp = new PartTimeEmp() { Id = 20 , Age = 22 , Name = "Hema"};
            ProcessEmp(partEmp);
            
            
            #endregion

            #endregion

        }
    }
}
