using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeleECM.Office.Models;

namespace TeleECM.Office
{
    public class TestData
    {
        private static Models.Group _group1 = new Group()
        {
            Id = "dsadsa",
            Name = "Отдел маркетинга"
        };

        private static Models.Group _group2 = new Group()
        {
            Id = "dsadsa-asd",
            Name = "Отдел управления"
        };

        private static Models.User _user1 = new User()
        {
            Id = "asadas-asdasd",
            Name = "Петров Иван",
            Username = "ivp@tele.kz",
            Groups = new List<Group>() {_group1 }
        };

        private static Models.User _user2 = new User()
        {
            Id = "asa-dasd",
            Name = "Илларионов Петр",
            Username = "ivani@tele.kz",
            Groups = new List<Group>() { _group2 }
        };

        private static Models.TaskUpdate _update1 = new TaskUpdate()
        {
            Id = "dasd-11a-asd-asd",
            User = _user2,
            Details = "Просмотр задания"
        };

        private static Models.TaskUpdate _update2 = new TaskUpdate()
        {
            Id = "dasd-11a-",
            User = _user2,
            DateTime = DateTime.Now.AddMinutes(3),
            Details = "Принято к исполнению"
        };

        private static Models.TaskUpdate _update3 = new TaskUpdate()
        {
            Id = "dasd",
            User = _user1,
            DateTime = DateTime.Now.AddDays(-3),
            Details = "Принято к исполнению"
        };


        private static Models.Task _testTask = new Models.Task()
        {
            Id = "sdadsa-asdas-asd-asd",
            Status = new Models.Status()
            {
                Id = "dsadasd",
                Title = "В работе"
            },
            Text = "<p>Ознакомиться \"Приказ об открытии дополнительных офисов(№ 2 - ПО от 10.03.2011)\"</p><p>Были внесены некоторые изменения. Просьба ознакомиться.</p>",
            Title = "Ознакомиться \"Приказ об открытии дополнительных офисов\"",
            Author = _user1,
            Users = new List<User>() { _user2},
            Updates = new List<TaskUpdate>()
            {
                _update1,
                _update2
            }
        };

        private static Models.Task _testTask2 = new Models.Task()
        {
            Id = "sdadsa-asdas-asd",
            Status = new Models.Status()
            {
                Id = "dsadasd",
                Title = "Готово"
            },
            Text = "<p>Поставщик: ООО НПЦ \"Меркурий\"</p><p>Покупатель: СтройКомплект ООО</p><p>Сумма: 250 000,00 RUB</p><p>Срок действия: с 01.04.2011 по 30.04.2017 Продлевается автоматически на год</p>",
            Title = "Выполнить оплату по договору",
            Author = _user2,
            Users = new List<User>() { _user2 },
            Updates = new List<TaskUpdate>()
            {
                _update3
            }
        };

        public static Models.Task TestTask => _testTask;

        public static Models.Task TestTask2 => _testTask2;
    }
}
