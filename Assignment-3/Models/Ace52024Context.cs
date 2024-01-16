using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BankRep.Models;

public partial class Ace52024Context : DbContext
{
    public Ace52024Context()
    {
    }

    public Ace52024Context(DbContextOptions<Ace52024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Aryan> Aryans { get; set; }

    public virtual DbSet<AryanSbaccount> AryanSbaccounts { get; set; }

    public virtual DbSet<AryanSbtransaction> AryanSbtransactions { get; set; }

    public virtual DbSet<Avika> Avikas { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Fpstudent> Fpstudents { get; set; }

    public virtual DbSet<Harshit> Harshits { get; set; }

    public virtual DbSet<Hetal> Hetals { get; set; }

    public virtual DbSet<Ivy> Ivies { get; set; }

    public virtual DbSet<Jayendra> Jayendras { get; set; }

    public virtual DbSet<Jivanshu> Jivanshus { get; set; }

    public virtual DbSet<Kartik> Kartiks { get; set; }

    public virtual DbSet<KartikSbaccount> KartikSbaccounts { get; set; }

    public virtual DbSet<KartikSbtransaction> KartikSbtransactions { get; set; }

    public virtual DbSet<Krina> Krinas { get; set; }

    public virtual DbSet<KritikaA> KritikaAs { get; set; }

    public virtual DbSet<Kush> Kushes { get; set; }

    public virtual DbSet<Muskan> Muskans { get; set; }

    public virtual DbSet<Pragati> Pragatis { get; set; }

    public virtual DbSet<Prerna> Prernas { get; set; }

    public virtual DbSet<Sandhya> Sandhyas { get; set; }

    public virtual DbSet<Sanskriti> Sanskritis { get; set; }

    public virtual DbSet<SbaccountJay> SbaccountJays { get; set; }

    public virtual DbSet<SbaccountSanskriti> SbaccountSanskritis { get; set; }

    public virtual DbSet<Sbaccountsivy> Sbaccountsivies { get; set; }

    public virtual DbSet<SbtransactionJay> SbtransactionJays { get; set; }

    public virtual DbSet<Sbtransactionacctivy> Sbtransactionacctivies { get; set; }

    public virtual DbSet<SbtransactionsSan> SbtransactionsSans { get; set; }

    public virtual DbSet<Shivya> Shivyas { get; set; }

    public virtual DbSet<Stud> Studs { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student007> Student007s { get; set; }

    public virtual DbSet<Student1> Students1 { get; set; }

    public virtual DbSet<Student27> Student27s { get; set; }

    public virtual DbSet<StudentDatum> StudentData { get; set; }

    public virtual DbSet<Studentss> Studentsses { get; set; }

    public virtual DbSet<Studenttt> Studenttts { get; set; }

    public virtual DbSet<Studentttt> Studentttts { get; set; }

    public virtual DbSet<Suhasini> Suhasinis { get; set; }

    public virtual DbSet<Suhasininew> Suhasininews { get; set; }

    public virtual DbSet<Suhasinitable> Suhasinitables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.Corp.local;Database=ACE 5- 2024;Trusted_Connection=True;encrypt = false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aryan>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__aryan__DDDFDD36A8A3380C");

            entity.ToTable("aryan");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<AryanSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__AryanSBA__BE2ACD6EFE99BFC6");

            entity.ToTable("AryanSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AryanSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__AryanSBT__55433A6B71704635");

            entity.ToTable("AryanSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.AryanSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__AryanSBTr__Accou__29221CFB");
        });

        modelBuilder.Entity<Avika>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__avika__DDDFDD36C4D1AF1A");

            entity.ToTable("avika");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__employee__DDDFDD361B1D6E6A");

            entity.ToTable("employee");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Fpstudent>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Fpstuden__DDDFDD363121B9DB");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Harshit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__harshit__3213E83FAA22F92F");

            entity.ToTable("harshit");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("first_name");
        });

        modelBuilder.Entity<Hetal>(entity =>
        {
            entity.HasKey(e => e.Sid);

            entity.ToTable("Hetal");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("SID");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<Ivy>(entity =>
        {
            entity.HasKey(e => e.Siiid).HasName("PK__studentt__3DBE29A1E0962EC7");

            entity.ToTable("ivy");

            entity.Property(e => e.Siiid)
                .ValueGeneratedNever()
                .HasColumnName("siiid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Jayendra>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Jayendra__AA2FFBE5513A081B");

            entity.ToTable("Jayendra");

            entity.Property(e => e.PersonId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Jivanshu>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__jivanshu__D9509F6DF8E8E366");

            entity.ToTable("jivanshu");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Doj).HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ename");
        });

        modelBuilder.Entity<Kartik>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__kartik__CA195950483E7AEB");

            entity.ToTable("kartik");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("SId");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        modelBuilder.Entity<KartikSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__kartik_S__BE2ACD6EB81381A8");

            entity.ToTable("kartik_SBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KartikSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__kartik_S__55433A6BAB019EB7");

            entity.ToTable("kartik_SBTransactions");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Krina>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Krina__DDDFDD36EAC230E4");

            entity.ToTable("Krina");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<KritikaA>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__KritikaA__AF2DBA792D46F755");

            entity.ToTable("KritikaA");

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("EmpID");
            entity.Property(e => e.Edept)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EDept");
            entity.Property(e => e.Edoj).HasColumnName("EDoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EName");
        });

        modelBuilder.Entity<Kush>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__kush__DDDFDD36992B3749");

            entity.ToTable("kush");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Muskan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__muskan__D9509F6DAD5D1BEC");

            entity.ToTable("muskan");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Doj).HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Pragati>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__pragati__DDDFDD36539475D8");

            entity.ToTable("pragati");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Prerna>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Prerna__DDDFDD36204B8DCB");

            entity.ToTable("Prerna");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Sandhya>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Sandhya__DDDFDD36D4582238");

            entity.ToTable("Sandhya");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Sanskriti>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__sanskrit__DDDFDD365FAABCAC");

            entity.ToTable("sanskriti");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<SbaccountJay>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__SBAccoun__BE2ACD6E515ADEA7");

            entity.ToTable("SBAccountJay");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbaccountSanskriti>(entity =>
        {
            entity.HasKey(e => e.Accno).HasName("PK__SBAccoun__A472931DE837D7A2");

            entity.ToTable("SBAccountSanskriti");

            entity.Property(e => e.Accno)
                .ValueGeneratedNever()
                .HasColumnName("accno");
            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.CurrAddress)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("curr_address");
            entity.Property(e => e.CurrBalance)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("curr_balance");
        });

        modelBuilder.Entity<Sbaccountsivy>(entity =>
        {
            entity.HasKey(e => e.Acctno).HasName("PK__Sbaccoun__402BC7DB6D07F537");

            entity.ToTable("Sbaccountsivy");

            entity.Property(e => e.Acctno).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbtransactionJay>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__SBTransa__55433A6BCAD45E63");

            entity.ToTable("SBTransactionJay");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TrancationType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.SbtransactionJays)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("fk");
        });

        modelBuilder.Entity<Sbtransactionacctivy>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__Sbtransa__9E5DDB3CD8D47E1A");

            entity.ToTable("Sbtransactionacctivy");

            entity.Property(e => e.TransId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<SbtransactionsSan>(entity =>
        {
            entity.HasKey(e => e.Transid).HasName("PK__SBTransa__DB1F6ABFB65C131A");

            entity.ToTable("SBTransactionsSans");

            entity.Property(e => e.Transid)
                .ValueGeneratedNever()
                .HasColumnName("transid");
            entity.Property(e => e.Accno).HasColumnName("accno");
            entity.Property(e => e.Amt)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("amt");
            entity.Property(e => e.Transdate).HasColumnName("transdate");
            entity.Property(e => e.Transtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("transtype");

            entity.HasOne(d => d.AccnoNavigation).WithMany(p => p.SbtransactionsSans)
                .HasForeignKey(d => d.Accno)
                .HasConstraintName("FK__SBTransac__accno__30C33EC3");
        });

        modelBuilder.Entity<Shivya>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Shivya__DDDFDD363E4C0512");

            entity.ToTable("Shivya");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Stud>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__stud__DDDFDD3692EC07E2");

            entity.ToTable("stud");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student__DDDFDD3626AAB5A7");

            entity.ToTable("student");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student007>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student0__DDDFDD36718934E4");

            entity.ToTable("student007");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student1>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__students__DDDFDD3690BE49A9");

            entity.ToTable("students");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student27>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student2__DDDFDD3652D91A1D");

            entity.ToTable("student27");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<StudentDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Doj)
                .HasColumnType("datetime")
                .HasColumnName("DOJ");
            entity.Property(e => e.Sname)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Studentss>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__students__DDDFDD36E67FC708");

            entity.ToTable("studentss");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Studenttt>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__studentt__DDDFDD36046BBB59");

            entity.ToTable("studenttt");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Studentttt>(entity =>
        {
            entity.HasKey(e => e.Siiid).HasName("PK__studentt__3DBE29A1BBC3441F");

            entity.ToTable("studentttt");

            entity.Property(e => e.Siiid)
                .ValueGeneratedNever()
                .HasColumnName("siiid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Suhasini>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Suhasini__AF4CE865B4F45413");

            entity.ToTable("Suhasini");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Empname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Suhasininew>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Suhasini__AF4CE865B5D05F55");

            entity.ToTable("Suhasininew");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Empname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Suhasinitable>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Suhasini__AF4CE865DE4625E0");

            entity.ToTable("Suhasinitable");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Empname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
