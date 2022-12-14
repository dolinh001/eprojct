// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace eProjectClient.Migrations
{
    [DbContext(typeof(MyDB_Context))]
    partial class MyDB_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Brand", b =>
                {
                    b.Property<string>("IdBrand")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_brand");

                    b.Property<string>("BrandName")
                        .HasColumnName("brand_name")
                        .HasMaxLength(50);

                    b.Property<bool>("Status")
                        .HasColumnName("status");

                    b.HasKey("IdBrand");

                    b.ToTable("brand");
                });

            modelBuilder.Entity("Data.DataModel.Account", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("userId");

                    b.Property<string>("Address")
                        .HasColumnName("address");

                    b.Property<int>("CountRrror")
                        .HasColumnName("counterror");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnName("birtday");

                    b.Property<bool>("Decentralization")
                        .HasColumnName("decentralization ");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .HasColumnName("fullName")
                        .HasMaxLength(50);

                    b.Property<bool>("Islock")
                        .HasColumnName("islock");

                    b.Property<string>("Password")
                        .HasColumnName("password");

                    b.Property<int>("Phone")
                        .HasColumnName("phone");

                    b.Property<int>("State")
                        .HasColumnName("state");

                    b.Property<DateTime?>("TimeLock")
                        .HasColumnName("timelock");

                    b.Property<string>("TokenChangePassword")
                        .HasColumnName("token_change_password");

                    b.Property<string>("UserName")
                        .HasColumnName("userName")
                        .HasMaxLength(50);

                    b.HasKey("UserId");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Data.DataModel.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("category_id");

                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name")
                        .HasMaxLength(50);

                    b.Property<bool>("Status")
                        .HasColumnName("status");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Data.DataModel.Certify", b =>
                {
                    b.Property<string>("IdCertify")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_certify");

                    b.Property<string>("CertifyType")
                        .HasColumnName("certify_type")
                        .HasMaxLength(50);

                    b.Property<string>("ImageCertify")
                        .HasColumnName("image_certify");

                    b.HasKey("IdCertify");

                    b.ToTable("certify");
                });

            modelBuilder.Entity("Data.DataModel.Comment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Account_Id")
                        .HasColumnName("account_id");

                    b.Property<string>("ContentComment")
                        .HasColumnName("content_comment");

                    b.Property<int>("Feedback")
                        .HasColumnName("feedback");

                    b.Property<string>("StyleCodeDimMst")
                        .HasColumnName("style_code_dim_mst");

                    b.Property<string>("StyleCodeItemProduct")
                        .HasColumnName("style_code_itemproduct");

                    b.Property<string>("StyleCodeStoneMst")
                        .HasColumnName("style_code_stone_mst");

                    b.HasKey("Id");

                    b.HasIndex("Account_Id");

                    b.HasIndex("StyleCodeDimMst");

                    b.HasIndex("StyleCodeItemProduct");

                    b.HasIndex("StyleCodeStoneMst");

                    b.ToTable("comment");
                });

            modelBuilder.Entity("Data.DataModel.DimMst", b =>
                {
                    b.Property<string>("Style_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("style_code");

                    b.Property<string>("Category_id")
                        .HasColumnName("category_id");

                    b.Property<string>("CertifyId")
                        .HasColumnName("certify_id");

                    b.Property<string>("Detail")
                        .HasColumnName("detail");

                    b.Property<float>("DimAmt")
                        .HasColumnName("dim_amt");

                    b.Property<float>("DimCrt")
                        .HasColumnName("dim_crt");

                    b.Property<float>("DimGm")
                        .HasColumnName("dim_gm");

                    b.Property<string>("DimMstName")
                        .HasColumnName("dimmst_name")
                        .HasMaxLength(150);

                    b.Property<float>("DimPcs")
                        .HasColumnName("dim_pcs");

                    b.Property<string>("DimQlty_Id")
                        .HasColumnName("dimqlty_id");

                    b.Property<int>("DimSize")
                        .HasColumnName("dim_size");

                    b.Property<string>("Dimsubtype_Id")
                        .HasColumnName("dimsubtype_id");

                    b.Property<string>("Image")
                        .HasColumnName("image");

                    b.HasKey("Style_Code");

                    b.HasIndex("Category_id");

                    b.HasIndex("CertifyId");

                    b.HasIndex("DimQlty_Id");

                    b.HasIndex("Dimsubtype_Id");

                    b.ToTable("dimmst");
                });

            modelBuilder.Entity("Data.DataModel.DimQltyMst", b =>
                {
                    b.Property<string>("DimqltyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dimqlty_id");

                    b.Property<int>("DimQlty")
                        .HasColumnName("dim_qlty");

                    b.HasKey("DimqltyId");

                    b.ToTable("dimqlty_mst");
                });

            modelBuilder.Entity("Data.DataModel.DimQltySubMst", b =>
                {
                    b.Property<string>("DimSub_TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dimsub_type_id");

                    b.Property<int>("DimQlty")
                        .HasColumnName("dimqlty");

                    b.HasKey("DimSub_TypeId");

                    b.ToTable("dimqlty_submst");
                });

            modelBuilder.Entity("Data.DataModel.Goldk", b =>
                {
                    b.Property<string>("GoldTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("goldtype_id");

                    b.Property<float>("GoldRate")
                        .HasColumnName("gold_rate");

                    b.Property<string>("Gold_Crt")
                        .HasColumnName("gold_crt");

                    b.HasKey("GoldTypeId");

                    b.ToTable("goldk");
                });

            modelBuilder.Entity("Data.DataModel.ImageProduct", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Image")
                        .HasColumnName("image");

                    b.Property<string>("StyleCodeDimMst")
                        .HasColumnName("style_code_dim_mst");

                    b.Property<string>("StyleCodeItemProduct")
                        .HasColumnName("style_code_itemproduct");

                    b.Property<string>("StyleCodeStoneMst")
                        .HasColumnName("style_code_stone_mst");

                    b.HasKey("Id");

                    b.HasIndex("StyleCodeDimMst");

                    b.HasIndex("StyleCodeItemProduct");

                    b.HasIndex("StyleCodeStoneMst");

                    b.ToTable("image_product");
                });

            modelBuilder.Entity("Data.DataModel.ItemProduct", b =>
                {
                    b.Property<string>("StyleCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("style_code");

                    b.Property<string>("BrandId")
                        .HasColumnName("brand_id");

                    b.Property<string>("Category_id")
                        .HasColumnName("category_id");

                    b.Property<string>("CertifyId")
                        .HasColumnName("certify_id");

                    b.Property<string>("Detail")
                        .HasColumnName("detail");

                    b.Property<string>("GoldTypeId")
                        .HasColumnName("goldtype_id");

                    b.Property<float>("Gold_Amt")
                        .HasColumnName("gold_amt");

                    b.Property<float?>("Gold_Making")
                        .HasColumnName("gold_making");

                    b.Property<float>("Gold_Rate")
                        .HasColumnName("gold_rate");

                    b.Property<float>("Gold_WT")
                        .HasColumnName("gold_wt");

                    b.Property<string>("Goldk");

                    b.Property<string>("ImageProduct")
                        .HasColumnName("image_product");

                    b.Property<string>("MRP")
                        .HasColumnName("mrp");

                    b.Property<float>("Net_Gold")
                        .HasColumnName("net_gold");

                    b.Property<float>("Other_Making")
                        .HasColumnName("other_making");

                    b.Property<int>("Pairs")
                        .HasColumnName("pairs");

                    b.Property<int>("ProQuality")
                        .HasColumnName("pro_quality");

                    b.Property<string>("ProductName")
                        .HasColumnName("product_name")
                        .HasMaxLength(150);

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity");

                    b.Property<float?>("Stone_Making")
                        .HasColumnName("stone_making");

                    b.Property<float>("Stone_WT")
                        .HasColumnName("stone_wt");

                    b.Property<float>("Total_Gross_WT")
                        .HasColumnName("total_gross_wt");

                    b.Property<float>("Total_Making")
                        .HasColumnName("total_making");

                    b.HasKey("StyleCode");

                    b.HasIndex("BrandId");

                    b.HasIndex("Category_id");

                    b.HasIndex("CertifyId");

                    b.ToTable("item_product");
                });

            modelBuilder.Entity("Data.DataModel.Order", b =>
                {
                    b.Property<string>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_order");

                    b.Property<string>("Account_Id")
                        .HasColumnName("account_id");

                    b.Property<string>("Address")
                        .HasColumnName("address");

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnName("booking_date");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnName("cancellation_date");

                    b.Property<string>("Note")
                        .HasColumnName("note");

                    b.Property<int>("Phone")
                        .HasColumnName("phone");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.Property<float>("Total")
                        .HasColumnName("total");

                    b.HasKey("IdOrder");

                    b.HasIndex("Account_Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Data.DataModel.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnName("booking_date");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnName("cancellation_date");

                    b.Property<string>("Image")
                        .HasColumnName("image");

                    b.Property<string>("Order_Id")
                        .HasColumnName("order_id");

                    b.Property<string>("ProductName")
                        .HasColumnName("product_name")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity");

                    b.Property<bool>("Status")
                        .HasColumnName("status");

                    b.Property<float>("Total")
                        .HasColumnName("total");

                    b.HasKey("Id");

                    b.HasIndex("Order_Id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Data.DataModel.StoneMst", b =>
                {
                    b.Property<string>("StyleCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("style_code");

                    b.Property<string>("Category_id")
                        .HasColumnName("category_id");

                    b.Property<string>("CertifyId")
                        .HasColumnName("certify_id");

                    b.Property<string>("Detail")
                        .HasColumnName("detail");

                    b.Property<string>("Image")
                        .HasColumnName("image");

                    b.Property<float>("MyProperty")
                        .HasColumnName("stone_crt");

                    b.Property<string>("StoneName")
                        .HasColumnName("stone_name")
                        .HasMaxLength(150);

                    b.Property<float>("Stone_Amt")
                        .HasColumnName("stone_amt");

                    b.Property<float>("Stone_DM")
                        .HasColumnName("stone_gm");

                    b.Property<float>("Stone_PCS")
                        .HasColumnName("stone_pcs");

                    b.Property<float>("Stone_Rate")
                        .HasColumnName("stone_rate");

                    b.Property<string>("StoneqltyId")
                        .HasColumnName("stoneqlty_id");

                    b.HasKey("StyleCode");

                    b.HasIndex("Category_id");

                    b.HasIndex("CertifyId");

                    b.HasIndex("StoneqltyId");

                    b.ToTable("stone_mst");
                });

            modelBuilder.Entity("Data.DataModel.StoneQltyMst", b =>
                {
                    b.Property<string>("StoneQltyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("stoneqlty_id");

                    b.Property<int>("StoneQlty")
                        .HasColumnName("stoneqlty");

                    b.HasKey("StoneQltyId");

                    b.ToTable("stone");
                });

            modelBuilder.Entity("Data.DataModel.Comment", b =>
                {
                    b.HasOne("Data.DataModel.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Account_Id");

                    b.HasOne("Data.DataModel.DimMst", "DimMst")
                        .WithMany()
                        .HasForeignKey("StyleCodeDimMst");

                    b.HasOne("Data.DataModel.ItemProduct", "ItemProduct")
                        .WithMany()
                        .HasForeignKey("StyleCodeItemProduct");

                    b.HasOne("Data.DataModel.StoneMst", "StoneMst")
                        .WithMany()
                        .HasForeignKey("StyleCodeStoneMst");
                });

            modelBuilder.Entity("Data.DataModel.DimMst", b =>
                {
                    b.HasOne("Data.DataModel.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_id");

                    b.HasOne("Data.DataModel.Certify", "Certify")
                        .WithMany()
                        .HasForeignKey("CertifyId");

                    b.HasOne("Data.DataModel.DimQltyMst", "DimQltyMst")
                        .WithMany()
                        .HasForeignKey("DimQlty_Id");

                    b.HasOne("Data.DataModel.DimQltySubMst", "DimQltySubMst")
                        .WithMany()
                        .HasForeignKey("Dimsubtype_Id");
                });

            modelBuilder.Entity("Data.DataModel.ImageProduct", b =>
                {
                    b.HasOne("Data.DataModel.DimMst", "DimMst")
                        .WithMany()
                        .HasForeignKey("StyleCodeDimMst");

                    b.HasOne("Data.DataModel.ItemProduct", "ItemProduct")
                        .WithMany()
                        .HasForeignKey("StyleCodeItemProduct");

                    b.HasOne("Data.DataModel.StoneMst", "StoneMst")
                        .WithMany()
                        .HasForeignKey("StyleCodeStoneMst");
                });

            modelBuilder.Entity("Data.DataModel.ItemProduct", b =>
                {
                    b.HasOne("Data.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("Data.DataModel.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_id");

                    b.HasOne("Data.DataModel.Certify", "Certify")
                        .WithMany()
                        .HasForeignKey("CertifyId");
                });

            modelBuilder.Entity("Data.DataModel.Order", b =>
                {
                    b.HasOne("Data.DataModel.Account", "Account")
                        .WithMany()
                        .HasForeignKey("Account_Id");
                });

            modelBuilder.Entity("Data.DataModel.OrderDetail", b =>
                {
                    b.HasOne("Data.DataModel.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Order_Id");
                });

            modelBuilder.Entity("Data.DataModel.StoneMst", b =>
                {
                    b.HasOne("Data.DataModel.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_id");

                    b.HasOne("Data.DataModel.Certify", "Certify")
                        .WithMany()
                        .HasForeignKey("CertifyId");

                    b.HasOne("Data.DataModel.StoneQltyMst", "StoneQltyMst")
                        .WithMany()
                        .HasForeignKey("StoneqltyId");
                });
#pragma warning restore 612, 618
        }
    }
}
