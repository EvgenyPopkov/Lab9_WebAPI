using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_WebAPI
{
    public class UserModel
    {
        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression("[a-zA-Zа-яА-Я]{1,20}", ErrorMessage = "Только буквы")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression("[a-zA-Zа-яА-Я]{1,20}", ErrorMessage = "Только буквы")]
        public string lastName { get; set; }

        [RegularExpression("[a-zA-Zа-яА-Я]{1,100}", ErrorMessage = "Только буквы")]
        public string city { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Введите дату")]
        public string date { get; set; }
    }
}
