using Autofac;
using WizardSoftwareGroupsFramework.Core.Utilities.Security;
using WizardSoftwareGroupsFramework.Core.Utilities.Security.Jwt;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Concrete;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework;

namespace WSG.CafeOtomation.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<TitleManager>().As<ITitleService>();
            builder.RegisterType<UserTitleManager>().As<IUserTitleService>();
            builder.RegisterType<EfTitleDal>().As<ITitleDal>();
            builder.RegisterType<EfUserTitleDal>().As<IUserTitleDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<PaymentManager>().As<IPaymentService>();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>();

            builder.RegisterType<PaymentDetailManager>().As<IPaymentDetailService>();
            builder.RegisterType<EfPaymentDetailDal>().As<IPaymentDetailDal>();

            builder.RegisterType<ProductCategoryManager>().As<IProductCategoryService>();
            builder.RegisterType<EfProductCategoryDal>().As<IProductCategoryDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<ProductTypeManager>().As<IProductTypeService>();
            builder.RegisterType<EfProductTypeDal>().As<IProductTypeDal>();

            builder.RegisterType<ProductImageManager>().As<IProductImageService>();
            builder.RegisterType<EfProductImageDal>().As<IProductImageDal>();

            builder.RegisterType<ProductDetailManager>().As<IProductDetailService>();
            builder.RegisterType<EfProductDetailDal>().As<IProductDetailDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>();
            builder.RegisterType<EfOrderDetailDal>().As<IOrderDetailDal>();

            builder.RegisterType<OrderDetailTypeManager>().As<IOrderDetailTypeService>();
            builder.RegisterType<EfOrderDetailTypeDal>().As<IOrderDetailTypeDal>();

            builder.RegisterType<OrderPaymentManager>().As<IOrderPaymentService>();
            builder.RegisterType<EfOrderPaymentDal>().As<IOrderPaymentDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<SupplierManager>().As<ISupplierService>();
            builder.RegisterType<EfSupplierDal>().As<ISupplierDal>();

            builder.RegisterType<CurrentBookManager>().As<ICurrentBookService>();
            builder.RegisterType<EfCurrentBookDal>().As<ICurrentBookDal>();

            builder.RegisterType<CurrentBookDetailManager>().As<ICurrentBookDetailService>();
            builder.RegisterType<EfCurrentBookDetailDal>().As<ICurrentBookDetailDal>();

            builder.RegisterType<DeskManager>().As<IDeskService>();
            builder.RegisterType<EfDeskDal>().As<IDeskDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
