using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _3._1.Data;
using _3._1.Models;

namespace _3._1.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly _3_1Context _context;

        public ValuesController(_3_1Context context)
        {
            _context = context;
        }
        /// <summary>
        /// все таблицы
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_all_agreements")]
        public async Task<ActionResult> GetAllData()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 number = operation.Number,
                                 deal_order = deal.Order,     
                                 name_sub = subAccount.Name,
                                 type = accountPlan.Type,
                                 
                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// Возврат всех данных о номерах по сделке 
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_two")]
        
        public async Task<ActionResult> GetTwo()
        {

            var agreement = (from operation in _context.Operation
                             
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                          
                             select new
                             {
                                 number_main = operation.Number,
                                 number_deal =deal.Number,
                                 number_sub = subAccount.Number,
                                 number_plan = accountPlan.Number,                              
                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// информация о покупке
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_tree")]
        public async Task<ActionResult> GetTree()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID         
                             select new
                             {
                                 deal_price = deal.Price,
                                 name_sub = subAccount.Name,
                                 number  = operation.Number,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// номер договора и имя
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_four")]
        public async Task<ActionResult> GetFour()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 deal_agreement = deal.Agreement,
                                 name = accountPlan.Type,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// общая сумма сделки и дата
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_five")]
        public async Task<ActionResult> GetFive()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 totalcost_deal = deal.TotalCost,
                                 data_deal = deal.Date,
                                 number_plan = accountPlan.Number,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// количество ценных бумаг и цена по одной 
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_six")]
        public async Task<ActionResult> GetSix()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 endsaldo = operation.SaldoOutput,
                                 quantity = deal.Quantity,
                                 price = deal.Price

                             }) ;


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// тип счета и имя
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_seven")]
        public async Task<ActionResult> seven()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 deal_order = deal.Order,
                                 name_sub = subAccount.Name,
                                 type = accountPlan.Type,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// расход при операции и комиссия
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_eight")]
        public async Task<ActionResult> Eight()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             select new
                             {
                                 sum = operation.Sum,
                                 totalCost = deal.TotalCost,
                                 commission = deal.Commission,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// дата и номер операции
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_nine")]
        public async Task<ActionResult> GetNine()
        {

            var agreement = (from operation in _context.Operation
                             
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 data = operation.Data,                                 
                                 number = accountPlan.Number,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// иноформация по трейдеру
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_ten")]
        public async Task<ActionResult> GetTen()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 trader = deal.Trader,
                                 number = subAccount.Number,
                                 number_plan = accountPlan.Number,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// тип операции и тикер ценной бумаги
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_eleven")]
        public async Task<ActionResult> GetEleven()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 type = operation.Type,
                                 tiker = deal.Tiker,
                                 type_plan = accountPlan.Type,

                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
        /// <summary>
        /// проверка на точную сумму сделки
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_twelve")]
        public async Task<ActionResult> GetTwelve()
        {

            var agreement = (from operation in _context.Operation
                             join deal in _context.Deal on operation.DealID equals deal.ID
                             join subAccount in _context.SubAccount on operation.SubAccountID equals subAccount.ID
                             join accountPlan in _context.AccountPlan on operation.SubAccountID equals accountPlan.ID
                             select new
                             {
                                 saldoInput = operation.SaldoInput,
                                 quantity = deal.Quantity,
                                 totalCost = deal.TotalCost,
                                 commission = deal.Commission,
                                 saldoOutput = operation.SaldoOutput,
                             });


            if (agreement == null)
            {
                return NotFound();
            }

            return Ok(agreement);
        }
    }
}
