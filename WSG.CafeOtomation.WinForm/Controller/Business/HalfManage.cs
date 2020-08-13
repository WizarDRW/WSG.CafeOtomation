using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.WinForm.Controller.Business
{
    public partial class HalfManage : Form
    {
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IProductService _productService;
        private User _user;
        private int _orderId;
        private int _deskId;
        private List<OrderDetailsDto> _getOrderDetails = new List<OrderDetailsDto>();
        private List<OrderDetailsDto> _orderDetailsSoft = new List<OrderDetailsDto>();
        private List<OrderDetail> _orderLeftDetails = new List<OrderDetail>();
        private List<OrderDetail> _orderRightDetails = new List<OrderDetail>();
        public delegate void Method_Add(OrderDetailsDto data);
        public HalfManage(IOrderService orderService, IOrderDetailService orderDetailService, IProductService productService, User user, int orderId, int deskId)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _orderId = orderId;
            _productService = productService;
            _deskId = deskId;
            _user = user;
            InitializeComponent();
        }

        private void HalfManage_Load(object sender, EventArgs e)
        {
            foreach (var item in _orderDetailService.GetAll(x => x.OrderID == _orderId).Data)
            {
                _getOrderDetails.Add(item);
            }
            DataGridOne_Load();
        }

        private void DataGridOne_Load()
        {
            dgvOne.DataSource = null;
            dgvOne.DataSource = _getOrderDetails;
            dgvOne.Columns["ID"].Visible = false;
            dgvOne.Columns["OrderID"].Visible = false;
            dgvOne.Columns["EOrderStatus"].Visible = false;
            dgvOne.Columns["ProductID"].Visible = false;
            dgvOne.Columns["CreateTime"].Visible = false;
        }

        private void DataGridTwo_Load()
        {
            dgvTwo.DataSource = null;
            dgvTwo.DataSource = _orderDetailsSoft;
            dgvTwo.Columns["ID"].Visible = false;
            dgvTwo.Columns["OrderID"].Visible = false;
            dgvTwo.Columns["EOrderStatus"].Visible = false;
            dgvTwo.Columns["ProductID"].Visible = false;
            dgvTwo.Columns["CreateTime"].Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bölmek istediğinize emin misiniz?","Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                foreach (var item in _getOrderDetails)
                {
                    var data = new OrderDetail
                    {
                        ID = item.ID,
                        ProductID = item.ProductID,
                        TotalPrice = item.TotalPrice,
                        OrderID = item.OrderID,
                        Amount = item.Amount,
                        UpdateDate = DateTime.Now,
                        EOrderStatus = OrderStatus.Complete,
                        UpdateUserID = _user.ID
                    };
                    _orderDetailService.Update(data);
                }
                var dataOrder = new Order
                {
                    DeskID = _deskId,
                    TotalPrice = _orderDetailsSoft.Sum(x => x.TotalPrice)
                };
                _orderService.Add(dataOrder);
                foreach (var item in _orderDetailsSoft)
                {
                    if (item.OrderID != 0)
                    {
                        item.OrderID = dataOrder.ID;
                        var dataOrderDetail = new OrderDetail
                        {
                            ID = item.ID,
                            ProductID = item.ProductID,
                            OrderID = dataOrder.ID,
                            Amount = item.Amount,
                            TotalPrice = item.TotalPrice,
                            UpdateDate = DateTime.Now,
                            UpdateUserID = _user.ID

                        };
                        _orderDetailService.Update(dataOrderDetail);
                    }
                }
                foreach (var item in _orderRightDetails)
                {
                    var dataOrderDetail = new OrderDetail
                    {
                        OrderID = dataOrder.ID,
                        ProductID = item.ProductID,
                        TotalPrice = item.TotalPrice,
                        CreateUserID = _user.ID,
                        CreateDate = DateTime.Now,
                        Amount = item.Amount,
                        EOrderStatus = OrderStatus.Complete
                    };
                    _orderDetailService.Add(dataOrderDetail);
                }
                btnCancel_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        private void dgvOne_DoubleClick(object sender, EventArgs e)
        {
            Method_Add method_Add = RightAll_Add;
            Double_Click((DataGridView)sender, _getOrderDetails, _orderDetailsSoft, _orderRightDetails, method_Add);
        }

        private void dgvTwo_DoubleClick(object sender, EventArgs e)
        {
            Method_Add method_Add = LeftAll_Add;
            Double_Click((DataGridView)sender, _orderDetailsSoft, _getOrderDetails, _orderLeftDetails, method_Add);
        }
        /// <summary>
        /// Bolumlemedeki hesaplarin eventlari
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="getorderDetailsDtos"></param>
        /// <param name="orderDetailsDtos"></param>
        /// <param name="orderDetails"></param>
        /// <param name="method_Add"></param>
        private void Double_Click(DataGridView dataGridView, List<OrderDetailsDto> getorderDetailsDtos, List<OrderDetailsDto> orderDetailsDtos, List<OrderDetail> orderDetails, Method_Add method_Add)
        {
            var product = _productService.GetByName(dataGridView.CurrentRow.Cells["Product"].Value.ToString()).Data;
            var data = getorderDetailsDtos.FirstOrDefault(x => x.ID == (int)dataGridView.CurrentRow.Cells["ID"].Value);
            if (data.Amount > 1)
            {
                DeskMenuHelper deskMenuHelper = new DeskMenuHelper();
                deskMenuHelper.ShowDialog();
                if (PropertyTraffics.ProductCount == null)
                {
                    return;
                }
                int count = (int)PropertyTraffics.ProductCount;
                if (count < 1)
                {
                    return;
                }
                if (data.Amount < count)
                {
                    MessageBox.Show("Ürün adeti aşıldı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (data.Amount == count)
                {
                    method_Add(data);
                    return;
                }
                var dataChilds = new OrderDetail
                {
                    ProductID = product.ID,
                    Amount = count,
                    TotalPrice = product.UnitPrice * count,
                    CreateUserID = _user.ID,
                    CreateDate = DateTime.Now
                };
                var dataSoftChilds = new OrderDetailsDto
                {
                    ID = data.ID,
                    Product = product.Name,
                    Amount = count,
                    TotalPrice = product.UnitPrice * count
                };
                data.Amount -= count;
                data.TotalPrice = product.UnitPrice * data.Amount;
                if (orderDetails.Where(x => x.ProductID == data.ProductID).Count() > 0)
                {
                    orderDetails.FirstOrDefault(x => x.ProductID == data.ProductID).Amount += count;
                    orderDetails.FirstOrDefault(x => x.ProductID == data.ProductID).TotalPrice += (product.UnitPrice * count);
                    orderDetailsDtos.FirstOrDefault(x => x.Product == data.Product).Amount += count;
                    orderDetailsDtos.FirstOrDefault(x => x.Product == data.Product).TotalPrice += (product.UnitPrice * count);
                }
                else
                {
                    orderDetails.Add(dataChilds);
                    orderDetailsDtos.Add(dataSoftChilds);
                }
                DataGridTwo_Load();
                DataGridOne_Load();
            }
            else if (data.Amount == 1)
            {
                method_Add(data);
            }
        }

        private void RightAll_Add(OrderDetailsDto data)
        {
            _orderDetailsSoft.Add(data);
            _getOrderDetails.Remove(data);
            DataGridTwo_Load();
            DataGridOne_Load();
            return;
        }

        private void LeftAll_Add(OrderDetailsDto data)
        {
            _getOrderDetails.Add(data);
            _orderDetailsSoft.Remove(data);
            DataGridTwo_Load();
            DataGridOne_Load();
            return;
        }
    }
}
