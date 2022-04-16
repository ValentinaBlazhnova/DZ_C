Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 2;

while(count <= numberA)
{
   if(count % 2 ==0)
   {
        Console.Write(count); 
        if (count < numberA-1)  //Проверка, чтобы не выводилась последняя запятая
        {
        Console.Write(", "); 
        }
    }
count++;
}

