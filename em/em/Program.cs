namespace d

//How Many employee objects do you need. Let's assume 10 for example
class employ
{ int NUM = 10;


    Employee[] employees = new Employee[NUM];
    // Declare an An array of employee's of length 10  (zero indexed from 0 - 9)

    //Assuming you have made Getters and Setters
    void getid();
    {}


//Then if you need to access an employee object's member(s)
employees[0].getId(); //get the first employee's id
employees[0].getName(); //get the first employee's name
employees[0].getSalary(); //get the first employee's name

// Or set them like
employees[4].setId(12); //set the fifth employee's id to 12
employees[4].setName("Joe Bloggs"); //set the fifth employee's name to Joe Bloggs
employees[4].setSalary("30000");