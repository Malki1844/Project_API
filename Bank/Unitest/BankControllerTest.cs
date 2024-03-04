//using Bank;
//using Bank.Controllers;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Unitest
//{
//    public class BankControllerTest
//    {
//        [Fact]
//        public void GetAll_ReturnOkOfTurn()
//        {
//            //aaa
//            //
//            //act
//            var controller=new TurnController();
//            var result= controller.Get();

//            //הכרזה
//            Assert.IsType<List<Turn>>(result);
//        }
//        [Fact]
//        public void GetById_ReturnOk()
//        {
//            //aaa
//            //
//            var id = 1;
//            //act
//            var controller = new TurnController();
//            var result = controller.Get(id);

//            //הכרזה
//            Assert.IsType<OkObjectResult>(result);
//        }
//        [Fact]
//        public void GetById_ReturnNotFound()
//        {
//            //aaa
//            //
//            var id = 8;
//            //act
//            var controller = new TurnController();
//            var result = controller.Get(id);

//            //הכרזה
//            Assert.IsType<NotFoundResult>(result);
//        }

//    }
//}
