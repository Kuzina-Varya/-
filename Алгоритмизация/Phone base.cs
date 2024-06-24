using static System.Runtime.InteropServices.JavaScript.JSType;

namespace phone_base
{/*На вход подаётся данные типа: номер телефона с которого звонили, номер на который звонили, дата звонка, количество минут;
  * определить на какой номер чаще всего звонил выбранный абонент по датам(сгрупировав данные по датам),
  * определить номера с которыми наибольшее количество минут разговаривал абонент(каждый абонент)(сгрупировав данные по дате)
  */
    internal class Program
    {
        class Phone_base
        {
            private string phone_number_from;
            private string phone_number_where;
            private string dates;
            private string minutes;
            public string Phone_number_from {  get { return phone_number_from; } set { phone_number_from = value; } }
            public string Phone_number_where { get {  return phone_number_where; } set { phone_number_where = value; } }
            public string Date { get { return dates; } set { dates = value; } }
            public string Minutes {  get { return minutes; } set {  minutes = value; } }
            public Phone_base(string phone_from,string phone_where,string date,string minute) 
            {
                Phone_number_from = phone_from;
                Phone_number_where = phone_where;
                Date = date;
                Minutes = minute;
            }
        }

        static void Main(string[] args)
        {
            string end = "END";
            Console.WriteLine("Введите " + end + " когда закончите ввод в базу! ");
            Console.WriteLine("Введите номер с которго звонили:");
            string str = Console.ReadLine();
            List<Phone_base> list = new List<Phone_base>();
            while (str != end)
            {

                string phone_from = str;
                Console.WriteLine("Введите номер на который звонили:");
                string phone_where = Console.ReadLine();
                Console.WriteLine("Введите дату звонка:");
                string date = Console.ReadLine();
                Console.WriteLine("Введите количество минут:");
                string minute = Console.ReadLine();
                Phone_base phone_base1 = new Phone_base(phone_from, phone_where, date, minute);
                list.Add(phone_base1);
                Console.WriteLine("Введите номер с которго звонили:");
                str = Console.ReadLine();

            }
            Console.WriteLine("Введите номер абонента для которого вы хотите узнать кому он чаще всего звонил:");
            string find_number_call = Console.ReadLine();
            int number = 0,int count = 0,int max = 0;
            for (int i=1;i<list.Count; i++)
            {
                for(int j=0;j<list.Count-1;j++)
                {
                    count = 0;
                    if ((list[j].Phone_number_from == find_number_call) && (list[j].Date == list[i].Date) && (list[j].Phone_number_where == list[i].Phone_number_where))
                    {
                        count++;
                        number = i;
                        if (count > max)
                        {
                            max = count;
                            Console.WriteLine($"дата:{list[i]}, кому звонил болльше всего:{last[i].Phone_number_where}");
                        }
                    }
                   

                }
                
            }
            /*string str = list[0].Phine_number_where;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Phone_number_from==find_number_call)
                {
                    str = list[i].Phone_number_where;
                    if()
                }
            }*/
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            for (int i = 0; i < list.Count; i++) 
            {
                Console.Write(list[i].Phone_number_from+" ");
                Console.Write(list[i].Phone_number_where + " ");
                Console.Write(list[i].Date + " ");
                Console.Write(list[i].Minutes + " ");
                Console.WriteLine();
            }
        }
    }
}
