/* Program: Car Repair
 * Programmer: Nate Pardee 
 * Date: 08/27/2023
 * Description: This program will take in vehicle information via user input. It
 *              will calculate and dislay the total costs of repairs and the information the user put in.
 */
class Program
{
    private static void Main(string[] args)
    {
        /********************
         Constants Declaration 
        *********************/
        const decimal SALES_TAX_RATE = 0.07m; //Stores sales tax rate as a decimal
        const decimal LABOR_COST_PER_HOUR = 100.00m; //Stores the labor cost per hour

        /********************
         non-constant variable declaration
        ********************/
        decimal labor_hours, parts_cost, labor_cost, subtotal, total, sales_tax;
        string customer_name, phone_number, car_make, car_model, car_year, work_description;

        /*******************************************
         Display Program name and Take in User Input
            -uses ReadLine method to take in user input
            -converts to appropriate data type from string if needed 
        ********************************************/
        Console.WriteLine("Welcome to the Car Repair Program");
        Console.WriteLine("---------------------------------\n");
        Console.WriteLine("Please enter the following information: \n");

        Console.Write("Customer's Name: ");
        customer_name = Console.ReadLine();

        Console.Write("Phone Number: ");
        phone_number = Console.ReadLine();

        Console.Write("Car Make: ");
        car_make = Console.ReadLine();

        Console.Write("Car Model: ");
        car_model = Console.ReadLine();

        Console.Write("Car Year: ");
        car_year = Console.ReadLine();

        Console.Write("Description of work performed: ");
        work_description = Console.ReadLine();

        Console.Write("Total labor hours: ");
        labor_hours = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Total parts Cost: ");
        parts_cost = Convert.ToDecimal(Console.ReadLine());

        /*******************
          Calcutations
        *******************/
        labor_cost = LABOR_COST_PER_HOUR * labor_hours;
        subtotal = labor_cost + parts_cost;
        sales_tax = SALES_TAX_RATE * subtotal;
        total = subtotal + sales_tax;

        /******************************
         Output Customer information
            -print out customer information with manual formatting
        ******************************/
        Console.WriteLine("\nCustomer information \n");
        Console.WriteLine($"Customer Name:               {customer_name}");
        Console.WriteLine($"Customer Phone Number:       {phone_number}");
        Console.WriteLine("\nVehicle Information");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"Make:                        {car_make}");
        Console.WriteLine($"Model:                       {car_model}");
        Console.WriteLine($"Work Performed:              {work_description}");
        Console.WriteLine();

        /**************************
         Output Costs with formatted string:
            -store formatted string into a variable and output to console
        ***************************/
        Console.WriteLine("Costs");
        Console.WriteLine("-----------------------------------------------------------");

        String formatted_labor_cost = String.Format("{0, -20} {1, 15:C2}", "Labor Cost:", labor_cost);
        Console.WriteLine(formatted_labor_cost);

        String formatted_parts_cost = String.Format("{0, -20} {1, 15:C2}", "Parts Cost:", parts_cost);
        Console.WriteLine(formatted_parts_cost);

        String formatted_subtotal = String.Format("{0, -20} {1, 15:C2}", "Subtotal:", subtotal);
        Console.WriteLine(formatted_subtotal);

        String formatted_sales_tax = String.Format("{0, -20} {1, 15:C2}", "Sales Tax:", sales_tax);
        Console.WriteLine(formatted_sales_tax);

        String formatted_total = String.Format("{0, -20} {1, 15:C2}", "total:", total);
        Console.WriteLine(formatted_total);
    }
}