// Задача1. написать программу, которая принимает на вход координаты 
// точки (х, у), причем они не равны 0,
// программа должна выдавать четверти плоскости, в которой 
// находятся эти точки

// void SearchSquad(int x, int y){
//     if(x==0 || y==0)
//         Console.WriteLine("Error");
//     else if(x>0 && y<0)
//         Console.WriteLine("Point is in the 4th Squad");
//     else if(x<0 && y<0)
//         Console.WriteLine("Point is in the 3rd Squad");
//     else if(x<0 && y>0)
//         Console.WriteLine("Point is in the 2nd Squad");
//     else
//         Console.WriteLine("Point is in the 1st Squad");
// }

// Console.Write("Enter coordinate of X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter coordinate of Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// SearchSquad(x, y);


// Задача2. написать программу, которая по заданному
// номеру четверти показывает диапазон
// возможных координат точек в этой четверти (х и у)

// void SearchRange(int squad){
//     if(squad == 1)
//         Console.WriteLine("x > 0, y > 0");
//     else if(squad == 2)
//         Console.WriteLine("x < 0, y > 0");
//     else if(squad == 3)
//         Console.WriteLine("x < 0, y < 0");
//     else if(squad == 4)
//         Console.WriteLine("x > 0, y < 0");
//     else 
//         Console.WriteLine("Try again");
    
// }
// Console.WriteLine("Enter the number of the squad: ");
// int squad = Convert.ToInt32(Console.ReadLine());
// SearchRange(squad);