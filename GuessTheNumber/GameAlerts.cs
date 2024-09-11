﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber.Output;
using GuessTheNumber.Input;

namespace GuessTheNumber
{
    internal class GameAlerts
    {
        public static string Start() => "Игра началась.";

        public static string End() => "Игра закончилась.";

        public static string Params() => "Настройки игры:";

        public static string Hot() => "Горячо.";

        public static string Cold() => "Холодно.";

        public static string VeryHot() => "Очень горячо.";

        public static string VeryCold() => "Очень холодно.";

        public static string Far() => "Вы отклонились.";

        public static string Close() => "Вы стали ближе.";

        public static string MoreThanHalf() => "Число больше половины пути.";

        public static string LessThanHalf() => "Число меньше половины пути.";

        public static string Even() => "Число четное.";

        public static string Odd() => "Число нечетное.";

        public static string MoreThanZero() => "Число больше нуля";

        public static string LessThanZero() => "Число меньше нуля";
    }
}