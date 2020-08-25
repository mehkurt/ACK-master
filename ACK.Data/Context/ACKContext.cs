using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ACK.Data.Models
{
    public partial class ACKContext : DbContext
    {
        public ACKContext()
        {
        }

        public ACKContext(DbContextOptions<ACKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLogTypes> ActivityLogTypes { get; set; }
        public virtual DbSet<ActivityLogs> ActivityLogs { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerContents> CustomerContents { get; set; }
        public virtual DbSet<CustomerCustomerRoleMappings> CustomerCustomerRoleMappings { get; set; }
        public virtual DbSet<CustomerRoles> CustomerRoles { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DeliveryTimes> DeliveryTimes { get; set; }
        public virtual DbSet<EventMappings> EventMappings { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<ExternalAuthenticationRecords> ExternalAuthenticationRecords { get; set; }
        public virtual DbSet<GenericAttributes> GenericAttributes { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LocaleStringResources> LocaleStringResources { get; set; }
        public virtual DbSet<LocalizedProperties> LocalizedProperties { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<MediaStorages> MediaStorages { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComments> NewsComments { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<OrderNotes> OrderNotes { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<PermissionRecordRoleMappings> PermissionRecordRoleMappings { get; set; }
        public virtual DbSet<PermissionRecords> PermissionRecords { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<ProductAttributeMappings> ProductAttributeMappings { get; set; }
        public virtual DbSet<ProductAttributeOptions> ProductAttributeOptions { get; set; }
        public virtual DbSet<ProductAttributeOptionsSets> ProductAttributeOptionsSets { get; set; }
        public virtual DbSet<ProductAttributes> ProductAttributes { get; set; }
        public virtual DbSet<ProductBundleItems> ProductBundleItems { get; set; }
        public virtual DbSet<ProductCategoryMappings> ProductCategoryMappings { get; set; }
        public virtual DbSet<ProductManufacturerMappings> ProductManufacturerMappings { get; set; }
        public virtual DbSet<ProductPictureMappings> ProductPictureMappings { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulness { get; set; }
        public virtual DbSet<ProductReviews> ProductReviews { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMappings> ProductSpecificationAttributeMappings { get; set; }
        public virtual DbSet<ProductTagMappings> ProductTagMappings { get; set; }
        public virtual DbSet<ProductTags> ProductTags { get; set; }
        public virtual DbSet<ProductVariantAttributeCombinations> ProductVariantAttributeCombinations { get; set; }
        public virtual DbSet<ProductVariantAttributeValues> ProductVariantAttributeValues { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<QuantityUnits> QuantityUnits { get; set; }
        public virtual DbSet<RelatedProducts> RelatedProducts { get; set; }
        public virtual DbSet<RewardPointsHistories> RewardPointsHistories { get; set; }
        public virtual DbSet<ScheduleTasks> ScheduleTasks { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<ShipmentItems> ShipmentItems { get; set; }
        public virtual DbSet<Shipments> Shipments { get; set; }
        public virtual DbSet<ShippingByTotals> ShippingByTotals { get; set; }
        public virtual DbSet<ShippingMethods> ShippingMethods { get; set; }
        public virtual DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }
        public virtual DbSet<SpecificationAttributeOptions> SpecificationAttributeOptions { get; set; }
        public virtual DbSet<SpecificationAttributes> SpecificationAttributes { get; set; }
        public virtual DbSet<StateProvinces> StateProvinces { get; set; }
        public virtual DbSet<TaxCategories> TaxCategories { get; set; }
        public virtual DbSet<UrlRecords> UrlRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=178.32.176.207;initial catalog=ACK;persist security info=True;user id=ackusr;password=Ack2020*+;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLogTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ActivityLogs>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.ActivityLogTypeId)
                    .HasConstraintName("FK_dbo.ActivityLog_dbo.ActivityLogType_ActivityLogTypeId");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(4000);

                entity.Property(e => e.Address2).HasMaxLength(4000);

                entity.Property(e => e.City).HasMaxLength(4000);

                entity.Property(e => e.Company).HasMaxLength(4000);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(4000);

                entity.Property(e => e.FaxNumber).HasMaxLength(4000);

                entity.Property(e => e.FirstName).HasMaxLength(4000);

                entity.Property(e => e.LastName).HasMaxLength(4000);

                entity.Property(e => e.PhoneNumber).HasMaxLength(4000);

                entity.Property(e => e.ZipPostalCode).HasMaxLength(4000);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Address_dbo.Country_CountryId");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("FK_dbo.Address_dbo.StateProvince_StateProvinceId");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.BadgeText).HasMaxLength(400);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(400);

                entity.Property(e => e.MetaDescription).HasMaxLength(4000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("FK_dbo.Category_dbo.Picture_PictureId");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.DomainEndings).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.RoundNumDecimals).HasDefaultValueSql("((2))");

                entity.Property(e => e.RoundOrderTotalDenominator).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId })
                    .HasName("PK_dbo.CustomerAddresses");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_dbo.CustomerAddresses_dbo.Address_Address_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.CustomerAddresses_dbo.Customer_Customer_Id");
            });

            modelBuilder.Entity<CustomerContents>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContents)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.CustomerContent_dbo.Customer_CustomerId");
            });

            modelBuilder.Entity<CustomerCustomerRoleMappings>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId })
                    .HasName("PK_dbo.CustomerustomerRoleMappings");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.Customer_CustomerRole_Mapping_dbo.Customer_Customer_Id");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_dbo.Customer_CustomerRole_Mapping_dbo.CustomerRole_CustomerRole_Id");
            });

            modelBuilder.Entity<CustomerRoles>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.AdminComment).HasMaxLength(4000);

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.LastActivityDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LastIpAddress).HasMaxLength(100);

                entity.Property(e => e.LastLoginDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.PasswordSalt).HasMaxLength(500);

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                entity.Property(e => e.SystemName).HasMaxLength(500);

                entity.Property(e => e.Username).HasMaxLength(500);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.CustomersBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("FK_dbo.Customer_dbo.Address_BillingAddress_Id");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.CustomersShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("FK_dbo.Customer_dbo.Address_ShippingAddress_Id");
            });

            modelBuilder.Entity<DeliveryTimes>(entity =>
            {
                entity.Property(e => e.ColorHexValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EventMappings>(entity =>
            {
                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.Property(e => e.ContentDeliveryNetwork).HasMaxLength(400);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Hosts).HasMaxLength(1000);

                entity.Property(e => e.HtmlBodyId).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PrimaryCurrencyId).HasDefaultValueSql("((1))");

                entity.Property(e => e.PrimaryExchangeRateCurrencyId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SecureUrl).HasMaxLength(400);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.PrimaryCurrency)
                    .WithMany(p => p.EventsPrimaryCurrency)
                    .HasForeignKey(d => d.PrimaryCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Event_dbo.Currency_PrimaryStoreCurrencyId");

                entity.HasOne(d => d.PrimaryExchangeRateCurrency)
                    .WithMany(p => p.EventsPrimaryExchangeRateCurrency)
                    .HasForeignKey(d => d.PrimaryExchangeRateCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Event_dbo.Currency_PrimaryExchangeRateCurrencyId");
            });

            modelBuilder.Entity<ExternalAuthenticationRecords>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(4000);

                entity.Property(e => e.ExternalDisplayIdentifier).HasMaxLength(4000);

                entity.Property(e => e.ExternalIdentifier).HasMaxLength(4000);

                entity.Property(e => e.OauthAccessToken)
                    .HasColumnName("OAuthAccessToken")
                    .HasMaxLength(4000);

                entity.Property(e => e.OauthToken)
                    .HasColumnName("OAuthToken")
                    .HasMaxLength(4000);

                entity.Property(e => e.ProviderSystemName).HasMaxLength(4000);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalAuthenticationRecords)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.ExternalAuthenticationRecord_dbo.Customer_CustomerId");
            });

            modelBuilder.Entity<GenericAttributes>(entity =>
            {
                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResources>(entity =>
            {
                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResources)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_dbo.LocaleStringResource_dbo.Language_LanguageId");
            });

            modelBuilder.Entity<LocalizedProperties>(entity =>
            {
                entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperties)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_dbo.LocalizedProperty_dbo.Language_LanguageId");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.HttpMethod).HasMaxLength(10);

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageUrl).HasMaxLength(1500);

                entity.Property(e => e.ReferrerUrl).HasMaxLength(1500);

                entity.Property(e => e.ShortMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Log_dbo.Customer_CustomerId");
            });

            modelBuilder.Entity<Manufacturers>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaDescription).HasMaxLength(4000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.Manufacturers)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("FK_dbo.Manufacturer_dbo.Picture_PictureId");
            });

            modelBuilder.Entity<MediaStorages>(entity =>
            {
                entity.Property(e => e.Data).IsRequired();
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.EndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaDescription).HasMaxLength(4000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Short)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.StartDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_dbo.News_dbo.Language_LanguageId");
            });

            modelBuilder.Entity<NewsComments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentTitle).HasMaxLength(4000);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.NewsComments)
                    .HasForeignKey<NewsComments>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NewsComment_dbo.CustomerContent_Id");

                entity.HasOne(d => d.NewsItem)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.NewsItemId)
                    .HasConstraintName("FK_dbo.NewsComment_dbo.News_NewsItemId");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.Property(e => e.AttributeDescription).HasMaxLength(4000);

                entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_dbo.OrderItem_dbo.Order_OrderId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.OrderItem_dbo.Product_ProductId");
            });

            modelBuilder.Entity<OrderNotes>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderNotes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_dbo.OrderNote_dbo.Order_OrderId");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.AuthorizationTransactionCode).HasMaxLength(4000);

                entity.Property(e => e.AuthorizationTransactionId).HasMaxLength(4000);

                entity.Property(e => e.AuthorizationTransactionResult).HasMaxLength(4000);

                entity.Property(e => e.CaptureTransactionId).HasMaxLength(4000);

                entity.Property(e => e.CaptureTransactionResult).HasMaxLength(4000);

                entity.Property(e => e.CardCvv2).HasMaxLength(4000);

                entity.Property(e => e.CardExpirationMonth).HasMaxLength(4000);

                entity.Property(e => e.CardExpirationYear).HasMaxLength(4000);

                entity.Property(e => e.CardName).HasMaxLength(4000);

                entity.Property(e => e.CardNumber).HasMaxLength(4000);

                entity.Property(e => e.CardType).HasMaxLength(4000);

                entity.Property(e => e.CheckoutAttributeDescription).HasMaxLength(4000);

                entity.Property(e => e.CheckoutAttributesXml).HasMaxLength(4000);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CreditBalance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CustomerCurrencyCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerIp).HasMaxLength(4000);

                entity.Property(e => e.DirectDebitAccountHolder).HasMaxLength(4000);

                entity.Property(e => e.DirectDebitAccountNumber).HasMaxLength(4000);

                entity.Property(e => e.DirectDebitBankCode).HasMaxLength(4000);

                entity.Property(e => e.DirectDebitBankName).HasMaxLength(4000);

                entity.Property(e => e.DirectDebitBic)
                    .HasColumnName("DirectDebitBIC")
                    .HasMaxLength(4000);

                entity.Property(e => e.DirectDebitCountry).HasMaxLength(4000);

                entity.Property(e => e.DirectDebitIban).HasMaxLength(4000);

                entity.Property(e => e.MaskedCreditCardNumber).HasMaxLength(4000);

                entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderNumber).HasMaxLength(4000);

                entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingTaxRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTotalRounding).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaidDateUtc).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeTaxRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodSystemName).HasMaxLength(4000);

                entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(4000);

                entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShippingMethod).HasMaxLength(4000);

                entity.Property(e => e.ShippingRateComputationMethodSystemName).HasMaxLength(4000);

                entity.Property(e => e.SubscriptionTransactionId).HasMaxLength(4000);

                entity.Property(e => e.TaxRates).HasMaxLength(4000);

                entity.Property(e => e.UpdatedOnUtc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('2018-06-13T16:26:15.545Z')");

                entity.Property(e => e.VatNumber).HasMaxLength(4000);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrdersBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Order_dbo.Address_BillingAddressId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.Order_dbo.Customer_CustomerId");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrdersShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("FK_dbo.Order_dbo.Address_ShippingAddressId");
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.Property(e => e.MetaDescription).HasMaxLength(4000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(4000);

                entity.Property(e => e.MetaTitle).HasMaxLength(4000);

                entity.Property(e => e.Password).HasMaxLength(4000);

                entity.Property(e => e.SystemName).HasMaxLength(4000);

                entity.Property(e => e.Title).HasMaxLength(4000);

                entity.Property(e => e.WidgetZone).HasMaxLength(4000);
            });

            modelBuilder.Entity<PaymentMethods>(entity =>
            {
                entity.Property(e => e.FullDescription).HasMaxLength(4000);

                entity.Property(e => e.PaymentMethodSystemName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<PermissionRecordRoleMappings>(entity =>
            {
                entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId })
                    .HasName("PK_dbo.PermissionRecord_Role_Mapping");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_dbo.PermissionRecord_Role_Mapping_dbo.CustomerRole_CustomerRole_Id");

                entity.HasOne(d => d.PermissionRecord)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.PermissionRecordId)
                    .HasConstraintName("FK_dbo.PermissionRecord_Role_Mapping_dbo.PermissionRecord_PermissionRecord_Id");
            });

            modelBuilder.Entity<PermissionRecords>(entity =>
            {
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.MediaStorage)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.MediaStorageId)
                    .HasConstraintName("FK_dbo.Picture_dbo.MediaStorage_MediaStorageId");
            });

            modelBuilder.Entity<ProductAttributeMappings>(entity =>
            {
                entity.Property(e => e.TextPrompt).HasMaxLength(4000);

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductAttributeMappings)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_dbo.Product_ProductAttribute_Mapping_dbo.ProductAttribute_ProductAttributeId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Product_ProductAttribute_Mapping_dbo.Product_ProductId");
            });

            modelBuilder.Entity<ProductAttributeOptions>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttributeOptionsSet)
                    .WithMany(p => p.ProductAttributeOptions)
                    .HasForeignKey(d => d.ProductAttributeOptionsSetId)
                    .HasConstraintName("FK_dbo.ProductAttributeOption_dbo.ProductAttributeOptionsSet_ProductAttributeOptionsSetId");
            });

            modelBuilder.Entity<ProductAttributeOptionsSets>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(400);

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductAttributeOptionsSets)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_dbo.ProductAttributeOptionsSet_dbo.ProductAttribute_ProductAttributeId");
            });

            modelBuilder.Entity<ProductAttributes>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.AllowFiltering)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<ProductBundleItems>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.BundleProduct)
                    .WithMany(p => p.ProductBundleItemsBundleProduct)
                    .HasForeignKey(d => d.BundleProductId)
                    .HasConstraintName("FK_dbo.ProductBundleItem_dbo.Product_BundleProductId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductBundleItemsProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProductBundleItem_dbo.Product_ProductId");
            });

            modelBuilder.Entity<ProductCategoryMappings>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Product_Category_Mapping_dbo.Category_CategoryId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Product_Category_Mapping_dbo.Product_ProductId");
            });

            modelBuilder.Entity<ProductManufacturerMappings>(entity =>
            {
                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_dbo.Product_Manufacturer_Mapping_dbo.Manufacturer_ManufacturerId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Product_Manufacturer_Mapping_dbo.Product_ProductId");
            });

            modelBuilder.Entity<ProductPictureMappings>(entity =>
            {
                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("FK_dbo.Product_Picture_Mapping_dbo.Picture_PictureId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Product_Picture_Mapping_dbo.Product_ProductId");
            });

            modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ProductReviewHelpfulness)
                    .HasForeignKey<ProductReviewHelpfulness>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProductReviewHelpfulness_dbo.CustomerContent_Id");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulness)
                    .HasForeignKey(d => d.ProductReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProductReviewHelpfulness_dbo.ProductReview_ProductReviewId");
            });

            modelBuilder.Entity<ProductReviews>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title).HasMaxLength(4000);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ProductReviews)
                    .HasForeignKey<ProductReviews>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ProductReview_dbo.CustomerContent_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.ProductReview_dbo.Product_ProductId");
            });

            modelBuilder.Entity<ProductSpecificationAttributeMappings>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Product_SpecificationAttribute_Mapping_dbo.Product_ProductId");

                entity.HasOne(d => d.SpecificationAttributeOption)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.SpecificationAttributeOptionId)
                    .HasConstraintName("FK_dbo.Product_SpecificationAttribute_Mapping_dbo.SpecificationAttributeOption_SpecificationAttributeOptionId");
            });

            modelBuilder.Entity<ProductTagMappings>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductTagId })
                    .HasName("PK_dbo.Product_ProductTag_Mapping");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTagMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Product_ProductTag_Mapping_dbo.Product_Product_Id");

                entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductTagMappings)
                    .HasForeignKey(d => d.ProductTagId)
                    .HasConstraintName("FK_dbo.Product_ProductTag_Mapping_dbo.ProductTag_ProductTag_Id");
            });

            modelBuilder.Entity<ProductTags>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductVariantAttributeCombinations>(entity =>
            {
                entity.Property(e => e.AssignedPictureIds).HasMaxLength(1000);

                entity.Property(e => e.AttributesXml).HasMaxLength(4000);

                entity.Property(e => e.BasePriceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.DeliveryTime)
                    .WithMany(p => p.ProductVariantAttributeCombinations)
                    .HasForeignKey(d => d.DeliveryTimeId)
                    .HasConstraintName("FK_dbo.ProductVariantAttributeCombination_dbo.DeliveryTime_DeliveryTimeId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVariantAttributeCombinations)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.ProductVariantAttributeCombination_dbo.Product_ProductId");

                entity.HasOne(d => d.QuantityUnit)
                    .WithMany(p => p.ProductVariantAttributeCombinations)
                    .HasForeignKey(d => d.QuantityUnitId)
                    .HasConstraintName("FK_dbo.ProductVariantAttributeCombination_dbo.QuantityUnit_QuantityUnitId");
            });

            modelBuilder.Entity<ProductVariantAttributeValues>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(100);

                entity.Property(e => e.Color).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductVariantAttribute)
                    .WithMany(p => p.ProductVariantAttributeValues)
                    .HasForeignKey(d => d.ProductVariantAttributeId)
                    .HasConstraintName("FK_dbo.ProductVariantAttributeValue_dbo.Product_ProductAttribute_Mapping_ProductVariantAttributeId");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AdminComment).HasMaxLength(4000);

                entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                entity.Property(e => e.AvailableEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.AvailableStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.BasePriceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BasePriceMeasureUnit).HasMaxLength(50);

                entity.Property(e => e.BundleTitleText).HasMaxLength(400);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CustomsTariffNumber).HasMaxLength(30);

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LowestAttributeCombinationPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetaDescription).HasMaxLength(4000);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);

                entity.Property(e => e.ShortDescription).HasMaxLength(4000);

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPriceEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.SpecialPriceStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UserAgreementText).HasMaxLength(4000);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CountryOfOrigin)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CountryOfOriginId)
                    .HasConstraintName("FK_dbo.Product_dbo.Country_CountryOfOriginId");

                entity.HasOne(d => d.DeliveryTime)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DeliveryTimeId)
                    .HasConstraintName("FK_dbo.Product_dbo.DeliveryTime_DeliveryTimeId");

                entity.HasOne(d => d.QuantityUnit)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.QuantityUnitId)
                    .HasConstraintName("FK_dbo.Product_dbo.QuantityUnit_QuantityUnitId");
            });

            modelBuilder.Entity<QuantityUnits>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RewardPointsHistories>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UsedWithOrderId).HasColumnName("UsedWithOrder_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RewardPointsHistories)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.RewardPointsHistory_dbo.Customer_CustomerId");

                entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.RewardPointsHistories)
                    .HasForeignKey(d => d.UsedWithOrderId)
                    .HasConstraintName("FK_dbo.RewardPointsHistory_dbo.Order_UsedWithOrder_Id");
            });

            modelBuilder.Entity<ScheduleTasks>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(500);

                entity.Property(e => e.CronExpression)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('0 */1 * * *')");

                entity.Property(e => e.LastEndUtc).HasColumnType("datetime");

                entity.Property(e => e.LastError).HasMaxLength(1000);

                entity.Property(e => e.LastStartUtc).HasColumnType("datetime");

                entity.Property(e => e.LastSuccessUtc).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.NextRunUtc).HasColumnType("datetime");

                entity.Property(e => e.ProgressMessage).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(800);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ShipmentItems>(entity =>
            {
                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_dbo.ShipmentItem_dbo.Shipment_ShipmentId");
            });

            modelBuilder.Entity<Shipments>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ShippedDateUtc).HasColumnType("datetime");

                entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TrackingNumber).HasMaxLength(4000);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_dbo.Shipment_dbo.Order_OrderId");
            });

            modelBuilder.Entity<ShippingByTotals>(entity =>
            {
                entity.Property(e => e.BaseCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.From).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingChargeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingChargePercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.To).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Zip).HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethods>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ShoppingCartItems>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.BundleItem)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.BundleItemId)
                    .HasConstraintName("FK_dbo.ShoppingCartItem_dbo.ProductBundleItem_BundleItemId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.ShoppingCartItem_dbo.Customer_CustomerId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.ShoppingCartItem_dbo.Product_ProductId");
            });

            modelBuilder.Entity<SpecificationAttributeOptions>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.NumberValue).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.SpecificationAttribute)
                    .WithMany(p => p.SpecificationAttributeOptions)
                    .HasForeignKey(d => d.SpecificationAttributeId)
                    .HasConstraintName("FK_dbo.SpecificationAttributeOption_dbo.SpecificationAttribute_SpecificationAttributeId");
            });

            modelBuilder.Entity<SpecificationAttributes>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<StateProvinces>(entity =>
            {
                entity.Property(e => e.Abbreviation).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.StateProvince_dbo.Country_CountryId");
            });

            modelBuilder.Entity<TaxCategories>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<UrlRecords>(entity =>
            {
                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
