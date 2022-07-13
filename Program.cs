using Voting;
try
{
    Console.WriteLine("\nLütfen kullanıcı adınızı giriniz: ");
    string user = Console.ReadLine().TrimEnd().TrimStart();

    bool log = Register.Login(user);
    if (!log)
    {
        Console.WriteLine("\nKaydınız bulunamadı. Kaydınızı gerçekleştiriyoruz..");
        Register reg = new Register(user);
    }
    Console.WriteLine("\nHoşgeldin {0}", user);
start:
    Console.WriteLine("\nLütfen Yapmak İstediğiniz işlemi seçin:\n1 - Oy Vermek\n2 - Oyları Görmek");
    int firstRes = Convert.ToInt32(Console.ReadLine());
    if (firstRes <= 2)
    {
        switch (firstRes)
        {
            case 1:
                Console.WriteLine("\nLütfen oy vereceğiniz kategoriyi seçiniz," +
        "\nSpor için 1," +
        "\nTeknoloji için 2," +
        "\nSinema için 3," +
        "\nKitap için 4");
                int select = Convert.ToInt32(Console.ReadLine());
                Voting_ vot = new Voting_(select);
                if (select <= 4)
                {
                    switch (select)
                    {
                        case 1:
                            Console.WriteLine($"Spor kategorisi için oy verdiniz");
                            Console.WriteLine("Oyunuz başarılı bir şekilde verilmiştir.\nYapmak istediğiniz işlemi seçiniz.\n1 - Yeniden oy vermek\n2 - Oyları Görmek\n3 - Çıkış");
                            int res = Convert.ToInt32(Console.ReadLine());
                            if (res <= 3)
                            {
                                switch (res)
                                {
                                    case 1:
                                        goto start;
                                    case 2:
                                        Console.WriteLine("\nOylar:");
                                        Console.WriteLine(Voting_.getResult());
                                        Console.WriteLine("\nMenüye dönmek için 1\nÇıkış yapmak için 2");
                                        int res9 = Convert.ToInt32(Console.ReadLine());
                                        if (res9 <= 2)
                                        {
                                            switch (res9)
                                            {
                                                case 1:
                                                    goto start;
                                                case 2:
                                                    Console.WriteLine("Görüşmek üzere...");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Görüşmek üzere...");
                                        break;
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Teknoloji kategorisi için oy verdiniz");
                            Console.WriteLine("Oyunuz başarılı bir şekilde verilmiştir.\nYapmak istediğiniz işlemi seçiniz.\n1 - Yeniden oy vermek\n2 - Oyları Görmek\n3 - Çıkış");
                            int res1 = Convert.ToInt32(Console.ReadLine());
                            if (res1 <= 3)
                            {
                                switch (res1)
                                {
                                    case 1:
                                        goto start;
                                    case 2:
                                        Console.WriteLine("\nOylar:");
                                        Console.WriteLine(Voting_.getResult());
                                        Console.WriteLine("\nMenüye dönmek için 1\nÇıkış yapmak için 2");
                                        int res8 = Convert.ToInt32(Console.ReadLine());
                                        if (res8 <= 2)
                                        {
                                            switch (res8)
                                            {
                                                case 1:
                                                    goto start;
                                                case 2:
                                                    Console.WriteLine("Görüşmek üzere");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Görüşmek üzere...");
                                        break;
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine($"Sinema kategorisi için oy verdiniz");
                            Console.WriteLine("Oyunuz başarılı bir şekilde verilmiştir.\nYapmak istediğiniz işlemi seçiniz.\n1 - Yeniden oy vermek\n2 - Oyları Görmek\n3 - Çıkış");
                            int res2 = Convert.ToInt32(Console.ReadLine());
                            if (res2 <= 3)
                            {
                                switch (res2)
                                {
                                    case 1:
                                        goto start;
                                    case 2:
                                        Console.WriteLine("\nOylar:");
                                        Console.WriteLine(Voting_.getResult());
                                        Console.WriteLine("\nMenüye dönmek için 1\nÇıkış yapmak için 2");
                                        int res7 = Convert.ToInt32(Console.ReadLine());
                                        if (res7 <= 2)
                                        {
                                            switch (res7)
                                            {
                                                case 1:
                                                    goto start;
                                                case 2:
                                                    Console.WriteLine("Görüşmek üzere");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Görüşmek üzere...");
                                        break;
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine($"Kitap kategorisi için oy verdiniz");
                            Console.WriteLine("Oyunuz başarılı bir şekilde verilmiştir.\nYapmak istediğiniz işlemi seçiniz.\n1 - Yeniden oy vermek\n2 - Oyları Görmek\n3 - Çıkış");
                            int res3 = Convert.ToInt32(Console.ReadLine());
                            if (res3 <= 3)
                            {
                                switch (res3)
                                {
                                    case 1:
                                        goto start;
                                    case 2:
                                        Console.WriteLine("\nOylar:");
                                        Console.WriteLine(Voting_.getResult());
                                        Console.WriteLine("\nMenüye dönmek için 1\nÇıkış yapmak için 2");
                                        int res7 = Convert.ToInt32(Console.ReadLine());
                                        if (res7 <= 2)
                                        {
                                            switch (res7)
                                            {
                                                case 1:
                                                    goto start;
                                                case 2:
                                                    Console.WriteLine("Görüşmek üzere");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Görüşmek üzere...");
                                        break;
                                }
                            }
                            break;
                    }
                }
                break;
            case 2:
                Console.WriteLine("\nOylar:");
                Console.WriteLine(Voting_.getResult());
                Console.WriteLine("\nMenüye dönmek için 1\nÇıkış Yapmak için 2");
                int lastRes = Convert.ToInt32(Console.ReadLine());
                if (lastRes <= 2)
                {
                    switch (lastRes)
                    {
                        case 1:
                            goto start;
                        case 2:
                            Console.WriteLine("Görüşmek üzere...");
                            break;
                    }
                }
                break;
        }
    }
}
catch (Exception e)
{
    Console.WriteLine("Hata!!", e.Message);
}
