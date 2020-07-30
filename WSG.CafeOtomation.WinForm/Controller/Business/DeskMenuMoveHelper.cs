using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.WinForm.Controller.Business
{
    public partial class DeskMenuMoveHelper : Form
    {
        private IDeskService _deskService;
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private Order _order;
        private List<int> _id;
        private User _user;
        public bool IsMove { get; set; }
        public DeskMenuMoveHelper(User user, Order order, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            InitializeComponent();
            _order = order;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _deskService = new DeskManager(new EfDeskDal());
            _user = user;
        }
        public DeskMenuMoveHelper(User user, List<int> ID, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            InitializeComponent();
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _deskService = new DeskManager(new EfDeskDal());
            _user = user;
            _id = ID;
        }

        private void DeskMenuMoveHelper_Load(object sender, EventArgs e)
        {
            var data = _deskService.GetAll().Data;
            foreach (var item in data)
            {
                cmbBxDesk.Items.Add(item.DeskNo);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var desk = _deskService.GetByNo(cmbBxDesk.SelectedItem.ToString()).Data;
            var data = _orderService.GetByDesk(desk.ID).Data.Where(x => x.OrderPayStatus == OrderPayStatus.Open).SingleOrDefault();
            if (_id != null)
            {
                if (data == null)
                {
                    decimal totalPrice = 0;
                    foreach (int item in _id)
                    {
                        totalPrice += _orderDetailService.GetBy(x => x.ID == item).Data.TotalPrice;
                    }
                    data = new Order
                    {
                        CreateUserID = _user.ID,
                        DeskID = desk.ID,
                        OrderPayStatus = OrderPayStatus.Open,
                        TotalPrice = totalPrice,
                        CreateDate = DateTime.Now
                    };
                    _orderService.Add(data);
                    foreach (var item in _id)
                    {
                        var orderDetail = _orderDetailService.GetBy(x => x.ID == item).Data;
                        orderDetail.OrderID = data.ID;
                        _orderDetailService.Update(orderDetail);
                    }
                }
                else
                {
                    foreach (var item in _id)
                    {
                        var orderDetail = _orderDetailService.GetBy(x => x.ID == item).Data;
                        orderDetail.OrderID = data.ID;
                        _orderDetailService.Update(orderDetail);
                    }
                }
            }
            else
            {
                if (data == null)
                {
                    _order.DeskID = desk.ID;
                    _orderService.Update(_order);
                }
                else
                {
                    foreach (var item in _orderDetailService.GetByOrderNo(_order.ID).Data)
                    {
                        item.OrderID = data.ID;
                        _orderDetailService.Update(item);
                    }
                    _orderService.Delete(_order);
                }
                IsMove = true;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsMove = false;
            this.Close();
        }

        private void cmbBxDesk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
