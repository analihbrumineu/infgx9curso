/*
               File: Funcionario
        Description: Cadastro de funcionários.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 8:48:38.58
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   /* Client and Server side code */
   public class tfuncionario : GXTransaction
   {
      public tfuncionario( int hnd ,
                           ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tfuncionario( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tfuncionario( IGxContext context ,
                           int hnd ,
                           ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey071( )
      {
         A38PesTipo = 0 ;
         n38PesTipo = false ;
         n38PesTipo = (((0==A38PesTipo)) ? true : false) ;
         A14PesNome = "" ;
         n14PesNome = false ;
         n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
         A111PesDat = (DateTime)(DateTime.MinValue) ;
         n111PesDat = false ;
         n111PesDat = (((DateTime.MinValue==A111PesDat)) ? true : false) ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         A25EstUF = "" ;
         n25EstUF = false ;
         A17PesEnde = "" ;
         n17PesEnde = false ;
         n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
         A12EstNome = "" ;
         n12EstNome = false ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
         A27CidNome = "" ;
         n27CidNome = false ;
         A18PesEndN = "" ;
         n18PesEndN = false ;
         n18PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
         A19PesBair = "" ;
         n19PesBair = false ;
         n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
         A20PesEmai = "" ;
         n20PesEmai = false ;
         n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
         A21PesTele = "" ;
         n21PesTele = false ;
         n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
         A22PesCelu = "" ;
         n22PesCelu = false ;
         n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
         A23PesSitu = 0 ;
         n23PesSitu = false ;
         n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
         A39PesFunC = 0 ;
         n39PesFunC = false ;
         n39PesFunC = (((0==A39PesFunC)) ? true : false) ;
         A42PesFunD = (DateTime)(DateTime.MinValue) ;
         n42PesFunD = false ;
         n42PesFunD = (((DateTime.MinValue==A42PesFunD)) ? true : false) ;
         A41PesFunD = (DateTime)(DateTime.MinValue) ;
         n41PesFunD = false ;
         n41PesFunD = (((DateTime.MinValue==A41PesFunD)) ? true : false) ;
         A43PesFunL = "" ;
         n43PesFunL = false ;
         n43PesFunL = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) ? true : false) ;
         A44PesFunS = "" ;
         n44PesFunS = false ;
         n44PesFunS = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A44PesFunS).TrimEnd(' ') )==0)) ? true : false) ;
         A40PesFunS = (decimal)(0M) ;
         n40PesFunS = false ;
         n40PesFunS = (((Convert.ToDecimal(0M)==A40PesFunS)) ? true : false) ;
      }

      protected void InitAll071( )
      {
         K13PesCodi = A13PesCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey071( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A38PesTipo = i38PesTipo ;
         cmbPesTipo.setValue(A38PesTipo);
         n38PesTipo = false ;
      }

      protected void ResetCaption070( )
      {
      }

      /* Client side code */
      public override void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
      }

      public override String getObjectName( )
      {
         return "Funcionario" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de funcionários." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null;
      }

      public override bool useCallersMenuBar( )
      {
         return true;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 1638 ;
      }

      public override int getFrmHeight( )
      {
         return 806 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TFuncionario.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public void execute( int aP0_PesCodigo ,
                           String aP1_Gx_mode )
      {
         this.A13PesCodi = aP0_PesCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1638 , 806 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtPesCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),195, 104, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 104 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" );
         ((GXEdit) edtPesCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtPesCodigo.addFocusListener(this);
         edtPesCodigo.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesCPF = new GUIObjectString ( new GXEdit(14, "999.999.999-99", UIFactory.getFont( "Courier New", 0, 9),195, 130, 117, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 130 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A15PesCPF" );
         ((GXEdit) edtPesCPF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesCPF.addFocusListener(this);
         edtPesCPF.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),429, 130, 260, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 429 , 130 , 260 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A14PesNome" );
         ((GXEdit) edtPesNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesNome.addFocusListener(this);
         edtPesNome.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesDatNascimento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),195, 156, 117, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 156 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A111PesDat" );
         ((GXEdit) edtPesDatNascimento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesDatNascimento.addFocusListener(this);
         edtPesDatNascimento.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         cmbPesSituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 429 , 156 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A23PesSitu" );
         ((GXComboBox) cmbPesSituacao.getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) cmbPesSituacao.getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         cmbPesSituacao.addFocusListener(this);
         cmbPesSituacao.addItemListener(this);
         cmbPesSituacao.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesTelefone = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),195, 182, 117, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 182 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A21PesTele" );
         ((GXEdit) edtPesTelefone.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesTelefone.addFocusListener(this);
         edtPesTelefone.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         cmbPesTipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 429 , 182 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A38PesTipo" );
         ((GXComboBox) cmbPesTipo.getGXComponent()).addItem( new java.lang.Short(1),"Cliente");
         ((GXComboBox) cmbPesTipo.getGXComponent()).addItem( new java.lang.Short(2),"Funcionário");
         cmbPesTipo.addFocusListener(this);
         cmbPesTipo.addItemListener(this);
         cmbPesTipo.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesCelular = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),195, 208, 117, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 208 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A22PesCelu" );
         ((GXEdit) edtPesCelular.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesCelular.addFocusListener(this);
         edtPesCelular.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesEmail = new GUIObjectString ( new GXEdit(100, "@!", UIFactory.getFont( "Courier New", 0, 9),195, 234, 195, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 234 , 195 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A20PesEmai" );
         ((GXEdit) edtPesEmail.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEmail.addFocusListener(this);
         edtPesEmail.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtEstCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),195, 260, 52, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 195 , 260 , 52 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" );
         ((GXEdit) edtEstCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtEstCodigo.addFocusListener(this);
         edtEstCodigo.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtEstNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),312, 260, 299, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 312 , 260 , 299 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A12EstNome" );
         ((GXEdit) edtEstNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstNome.addFocusListener(this);
         edtEstNome.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtEstUF = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),650, 260, 39, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 650 , 260 , 39 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" );
         ((GXEdit) edtEstUF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstUF.addFocusListener(this);
         edtEstUF.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtCidCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),195, 286, 52, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 286 , 52 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A26CidCodi" );
         ((GXEdit) edtCidCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCidCodigo.addFocusListener(this);
         edtCidCodigo.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtCidNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),312, 286, 299, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 312 , 286 , 299 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A27CidNome" );
         ((GXEdit) edtCidNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtCidNome.addFocusListener(this);
         edtCidNome.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesBairro = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),195, 312, 416, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 312 , 416 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A19PesBair" );
         ((GXEdit) edtPesBairro.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesBairro.addFocusListener(this);
         edtPesBairro.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesEndereco = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),195, 338, 416, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 338 , 416 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A17PesEnde" );
         ((GXEdit) edtPesEndereco.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEndereco.addFocusListener(this);
         edtPesEndereco.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesEndNumero = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),650, 338, 39, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 650 , 338 , 39 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A18PesEndN" );
         ((GXEdit) edtPesEndNumero.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEndNumero.addFocusListener(this);
         edtPesEndNumero.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         cmbPesFunCargo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 195 , 364 , 82 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A39PesFunC" );
         ((GXComboBox) cmbPesFunCargo.getGXComponent()).addItem( new java.lang.Short(1),"Gerente");
         ((GXComboBox) cmbPesFunCargo.getGXComponent()).addItem( new java.lang.Short(2),"Vendedor");
         cmbPesFunCargo.addFocusListener(this);
         cmbPesFunCargo.addItemListener(this);
         cmbPesFunCargo.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesFunSalario = new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),351, 364, 91, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 351 , 364 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A40PesFunS" );
         ((GXEdit) edtPesFunSalario.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtPesFunSalario.addFocusListener(this);
         edtPesFunSalario.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesFunDatAdmissao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),195, 390, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 195 , 390 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A42PesFunD" );
         ((GXEdit) edtPesFunDatAdmissao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesFunDatAdmissao.addFocusListener(this);
         edtPesFunDatAdmissao.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesFunDatDemissao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),351, 390, 91, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 351 , 390 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A41PesFunD" );
         ((GXEdit) edtPesFunDatDemissao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesFunDatDemissao.addFocusListener(this);
         edtPesFunDatDemissao.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesFunLogin = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),330, 442, 150, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 330 , 442 , 150 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A43PesFunL" );
         ((GXEdit) edtPesFunLogin.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesFunLogin.addFocusListener(this);
         edtPesFunLogin.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         edtPesFunSenha = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),330, 473, 150, 21, GXPanel1, true, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 330 , 473 , 150 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A44PesFunS" );
         ((GXEdit) edtPesFunSenha.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesFunSenha.addFocusListener(this);
         edtPesFunSenha.getGXComponent().setHelpId("HLP_TFuncionario.htm");
         bttbtt47 = UIFactory.getGXButton( GXPanel1 , "Enter" ,  572 ,  533 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt47.setTooltip("Enter");
         bttbtt47.addActionListener(this);
         lbllbl48 = UIFactory.getLabel(GXPanel1, "Cadastro de funcionários", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 142 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 108 , 40 , 13 );
         lbllbl19 = UIFactory.getLabel(GXPanel1, "CPF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 134 , 24 , 13 );
         lbllbl29 = UIFactory.getLabel(GXPanel1, "Nome completo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 321 , 134 , 88 , 13 );
         lbllbl21 = UIFactory.getLabel(GXPanel1, "Data de nascimento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 160 , 114 , 13 );
         lbllbl31 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 325 , 161 , 51 , 13 );
         lbllbl33 = UIFactory.getLabel(GXPanel1, "Telefone residencial", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 186 , 116 , 13 );
         lbllbl35 = UIFactory.getLabel(GXPanel1, "Tipo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 325 , 187 , 26 , 13 );
         lbllbl17 = UIFactory.getLabel(GXPanel1, "Celular", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 212 , 40 , 13 );
         lbllbl23 = UIFactory.getLabel(GXPanel1, "E-mail", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 238 , 35 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "Código do Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 264 , 101 , 13 );
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 260 , 264 , 40 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 624 , 264 , 17 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código da cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 290 , 100 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 260 , 290 , 40 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Bairro", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 316 , 34 , 13 );
         lbllbl25 = UIFactory.getLabel(GXPanel1, "Endereço", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 342 , 55 , 13 );
         lbllbl27 = UIFactory.getLabel(GXPanel1, "Nº", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 624 , 342 , 15 , 13 );
         lbllbl37 = UIFactory.getLabel(GXPanel1, "Cargo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 368 , 34 , 13 );
         lbllbl46 = UIFactory.getLabel(GXPanel1, "Salário", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 286 , 368 , 40 , 13 );
         lbllbl41 = UIFactory.getLabel(GXPanel1, "Data de admissão", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 394 , 102 , 13 );
         lbllbl39 = UIFactory.getLabel(GXPanel1, "Demissão", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 286 , 394 , 55 , 13 );
         lbllbl43 = UIFactory.getLabel(GXPanel1, "Login", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 286 , 446 , 32 , 13 );
         lbllbl45 = UIFactory.getLabel(GXPanel1, "Senha", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 287 , 477 , 37 , 13 );
         rctrct50 = UIFactory.getGXRectangle( GXPanel1 , 1 , 273 , 429 , 222 , 79 , Integer.MAX_VALUE , UIFactory.getColor(0) , ILabelConstants.BORDER_SINGLE );
         edtCidCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtPesCodigo ,
                   edtPesCPF ,
                   edtPesNome ,
                   edtPesDatNascimento ,
                   cmbPesSituacao ,
                   edtPesTelefone ,
                   cmbPesTipo ,
                   edtPesCelular ,
                   edtPesEmail ,
                   edtEstCodigo ,
                   edtEstNome ,
                   edtEstUF ,
                   edtCidCodigo ,
                   edtCidNome ,
                   edtPesBairro ,
                   edtPesEndereco ,
                   edtPesEndNumero ,
                   cmbPesFunCargo ,
                   edtPesFunSalario ,
                   edtPesFunDatAdmissao ,
                   edtPesFunDatDemissao ,
                   edtPesFunLogin ,
                   edtPesFunSenha ,
                   bttbtt47
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Pescodigo();
         setFocus(edtPesCPF, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey071( ) ;
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt47.setGXEnabled(0);
            edtPesCodigo.setEnabled(0);
            edtEstCodigo.setEnabled(0);
            edtEstNome.setEnabled(0);
            edtCidCodigo.setEnabled(0);
            edtEstUF.setEnabled(0);
            edtCidNome.setEnabled(0);
            edtPesBairro.setEnabled(0);
            edtPesCelular.setEnabled(0);
            edtPesCPF.setEnabled(0);
            edtPesDatNascimento.setEnabled(0);
            edtPesEmail.setEnabled(0);
            edtPesEndereco.setEnabled(0);
            edtPesEndNumero.setEnabled(0);
            edtPesNome.setEnabled(0);
            cmbPesSituacao.setEnabled(0);
            edtPesTelefone.setEnabled(0);
            cmbPesTipo.setEnabled(0);
            cmbPesFunCargo.setEnabled(0);
            edtPesFunDatDemissao.setEnabled(0);
            edtPesFunDatAdmissao.setEnabled(0);
            edtPesFunLogin.setEnabled(0);
            edtPesFunSenha.setEnabled(0);
            edtPesFunSalario.setEnabled(0);
            setFocus(bttbtt47, true);
         }
      }

      public override void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               base.context.msgStatus(GXResourceManager.GetMessage("confdelete"));
            }
            else
            {
               base.context.msgStatus(GXResourceManager.GetMessage("mustconfirm"));
            }
            bttbtt47.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttbtt47.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt47.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttbtt47.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt47.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttbtt47.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttbtt47.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttbtt47.setTooltip(GXResourceManager.GetMessage("captiondelete"));
         }
         else
         {
         }
      }

      protected void AfterTrn( )
      {
         if ( ( trnEnded == 1 ) )
         {
            trnEnded = 0 ;
            if (!cleanedUp) {
               standaloneNotModal( ) ;
               standaloneModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  )
               {
                  /* Clear variables for new insertion. */
                  InitAll071( ) ;
                  standaloneNotModal( ) ;
                  standaloneModal( ) ;
               }
            }
         }
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void GXEnter( )
      {
         btn_enter( ) ;
         if (!cleanedUp) {
            VariablesToControls();
            set_caption( );
         }
      }

      public override void GXStart( )
      {
         standaloneStartup( ) ;
         VariablesToControls();
         /* Execute Start event if defined. */
         /* Execute user event: E11072 */
         E11072 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         lastAnyError = AnyError ;
         AnyError = 0;
         if ( bttbtt47.isEventSource(eventSource) ) {
            if ( ( lastAnyError != 0 ) )
            {
               return;
            }
            btn_enter( ) ;
            if (!cleanedUp) {
               VariablesToControls();
               set_caption( );
            }
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtPesCodigo.getGXCursor() );
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtEstCodigo.getGXCursor() );
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            setGXCursor( edtEstNome.getGXCursor() );
            return;
         }
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtCidCodigo.getGXCursor() );
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            setGXCursor( edtEstUF.getGXCursor() );
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            setGXCursor( edtCidNome.getGXCursor() );
            return;
         }
         if ( edtPesBairro.isEventSource(eventSource) ) {
            setGXCursor( edtPesBairro.getGXCursor() );
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            setGXCursor( edtPesCelular.getGXCursor() );
            return;
         }
         if ( edtPesCPF.isEventSource(eventSource) ) {
            setGXCursor( edtPesCPF.getGXCursor() );
            return;
         }
         if ( edtPesDatNascimento.isEventSource(eventSource) ) {
            setGXCursor( edtPesDatNascimento.getGXCursor() );
            return;
         }
         if ( edtPesEmail.isEventSource(eventSource) ) {
            setGXCursor( edtPesEmail.getGXCursor() );
            return;
         }
         if ( edtPesEndereco.isEventSource(eventSource) ) {
            setGXCursor( edtPesEndereco.getGXCursor() );
            return;
         }
         if ( edtPesEndNumero.isEventSource(eventSource) ) {
            setGXCursor( edtPesEndNumero.getGXCursor() );
            return;
         }
         if ( edtPesNome.isEventSource(eventSource) ) {
            setGXCursor( edtPesNome.getGXCursor() );
            return;
         }
         if ( cmbPesSituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbPesSituacao.getGXCursor() );
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            setGXCursor( edtPesTelefone.getGXCursor() );
            return;
         }
         if ( cmbPesTipo.isEventSource(eventSource) ) {
            setGXCursor( cmbPesTipo.getGXCursor() );
            return;
         }
         if ( cmbPesFunCargo.isEventSource(eventSource) ) {
            setGXCursor( cmbPesFunCargo.getGXCursor() );
            return;
         }
         if ( edtPesFunDatDemissao.isEventSource(eventSource) ) {
            setGXCursor( edtPesFunDatDemissao.getGXCursor() );
            return;
         }
         if ( edtPesFunDatAdmissao.isEventSource(eventSource) ) {
            setGXCursor( edtPesFunDatAdmissao.getGXCursor() );
            return;
         }
         if ( edtPesFunLogin.isEventSource(eventSource) ) {
            setGXCursor( edtPesFunLogin.getGXCursor() );
            return;
         }
         if ( edtPesFunSenha.isEventSource(eventSource) ) {
            setGXCursor( edtPesFunSenha.getGXCursor() );
            return;
         }
         if ( edtPesFunSalario.isEventSource(eventSource) ) {
            setGXCursor( edtPesFunSalario.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtPesDatNascimento.isEventSource(eventSource) ) {
            Valid_Pesdatnascimento ();
            return;
         }
         if ( edtPesFunDatAdmissao.isEventSource(eventSource) ) {
            Valid_Pesfundatadmissao ();
            return;
         }
         if ( edtPesFunDatDemissao.isEventSource(eventSource) ) {
            Valid_Pesfundatdemissao ();
            return;
         }
         if ( edtPesFunLogin.isEventSource(eventSource) ) {
            Valid_Pesfunlogin ();
            return;
         }
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            Valid_Cidcodigo ();
            return;
         }
         if ( edtPesCPF.isEventSource(eventSource) ) {
            Valid_Pescpf ();
            return;
         }
         if ( edtPesNome.isEventSource(eventSource) ) {
            Valid_Pesnome ();
            return;
         }
         if ( edtPesFunSalario.isEventSource(eventSource) ) {
            Valid_Pesfunsalario ();
            return;
         }
         if ( edtPesFunSenha.isEventSource(eventSource) ) {
            Valid_Pesfunsenha ();
            return;
         }
         if ( edtPesBairro.isEventSource(eventSource) ) {
            Valid_Pesbairro ();
            return;
         }
         if ( edtPesEndereco.isEventSource(eventSource) ) {
            Valid_Pesendereco ();
            return;
         }
         if ( edtPesEndNumero.isEventSource(eventSource) ) {
            Valid_Pesendnumero ();
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            Valid_Pestelefone ();
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            Valid_Pescelular ();
            return;
         }
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            Valid_Pescodigo ();
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            Valid_Estcodigo ();
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            A13PesCodi = edtPesCodigo.getValue() ;
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            A24EstCodi = edtEstCodigo.getValue() ;
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            A12EstNome = edtEstNome.getValue() ;
            return;
         }
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            A26CidCodi = edtCidCodigo.getValue() ;
            n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            A25EstUF = edtEstUF.getValue() ;
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            A27CidNome = edtCidNome.getValue() ;
            return;
         }
         if ( edtPesBairro.isEventSource(eventSource) ) {
            A19PesBair = edtPesBairro.getValue() ;
            n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            A22PesCelu = edtPesCelular.getValue() ;
            n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesCPF.isEventSource(eventSource) ) {
            A15PesCPF = edtPesCPF.getValue() ;
            n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesDatNascimento.isEventSource(eventSource) ) {
            A111PesDat = edtPesDatNascimento.getValue() ;
            n111PesDat = (((DateTime.MinValue==A111PesDat)) ? true : false) ;
            return;
         }
         if ( edtPesEmail.isEventSource(eventSource) ) {
            A20PesEmai = edtPesEmail.getValue() ;
            n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesEndereco.isEventSource(eventSource) ) {
            A17PesEnde = edtPesEndereco.getValue() ;
            n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesEndNumero.isEventSource(eventSource) ) {
            A18PesEndN = edtPesEndNumero.getValue() ;
            n18PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesNome.isEventSource(eventSource) ) {
            A14PesNome = edtPesNome.getValue() ;
            n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( cmbPesSituacao.isEventSource(eventSource) ) {
            A23PesSitu = cmbPesSituacao.getValue() ;
            n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            A21PesTele = edtPesTelefone.getValue() ;
            n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( cmbPesTipo.isEventSource(eventSource) ) {
            A38PesTipo = cmbPesTipo.getValue() ;
            n38PesTipo = (((0==A38PesTipo)) ? true : false) ;
            return;
         }
         if ( cmbPesFunCargo.isEventSource(eventSource) ) {
            A39PesFunC = cmbPesFunCargo.getValue() ;
            n39PesFunC = (((0==A39PesFunC)) ? true : false) ;
            return;
         }
         if ( edtPesFunDatDemissao.isEventSource(eventSource) ) {
            A41PesFunD = edtPesFunDatDemissao.getValue() ;
            n41PesFunD = (((DateTime.MinValue==A41PesFunD)) ? true : false) ;
            return;
         }
         if ( edtPesFunDatAdmissao.isEventSource(eventSource) ) {
            A42PesFunD = edtPesFunDatAdmissao.getValue() ;
            n42PesFunD = (((DateTime.MinValue==A42PesFunD)) ? true : false) ;
            return;
         }
         if ( edtPesFunLogin.isEventSource(eventSource) ) {
            A43PesFunL = edtPesFunLogin.getValue() ;
            n43PesFunL = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesFunSenha.isEventSource(eventSource) ) {
            A44PesFunS = edtPesFunSenha.getValue() ;
            n44PesFunS = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A44PesFunS).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesFunSalario.isEventSource(eventSource) ) {
            A40PesFunS = edtPesFunSalario.getValue() ;
            n40PesFunS = (((Convert.ToDecimal(0M)==A40PesFunS)) ? true : false) ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E12072 */
            E12072 ();
            if (!cleanedUp) {
               VariablesToControls();
            }
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
            AnyError = 0;
            btn_enter( ) ;
            if (!cleanedUp) {
               VariablesToControls();
               set_caption( );
            }
            return true ;
         }
         if (keyCode == getContext().getClientPreferences().getKEY_PROMPT()) {
            return promptHandler(eventSource);
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         if ( ( String.CompareOrdinal(action.TrimEnd(' '), "BROWSE".TrimEnd(' ') ) == 0 ) )
         {
            return promptHandler(eventSource) ;
         }
         return false;
      }

      public override bool isKeyControl( Object eventSource )
      {
         if ( ( edtPesCodigo.isEventSource(eventSource) ) && ( ( A13PesCodi != edtPesCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( edtEstCodigo.isEventSource(eventSource) ) && ( ( A24EstCodi != edtEstCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtEstNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A12EstNome.TrimEnd(' '), edtEstNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtCidCodigo.isEventSource(eventSource) ) && ( ( A26CidCodi != edtCidCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtEstUF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A25EstUF.TrimEnd(' '), edtEstUF.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtCidNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A27CidNome.TrimEnd(' '), edtCidNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesBairro.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A19PesBair.TrimEnd(' '), edtPesBairro.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesCelular.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A22PesCelu.TrimEnd(' '), edtPesCelular.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesCPF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A15PesCPF.TrimEnd(' '), edtPesCPF.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesDatNascimento.isEventSource(eventSource) ) && ( ( A111PesDat != edtPesDatNascimento.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesEmail.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A20PesEmai.TrimEnd(' '), edtPesEmail.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesEndereco.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A17PesEnde.TrimEnd(' '), edtPesEndereco.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesEndNumero.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A18PesEndN.TrimEnd(' '), edtPesEndNumero.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A14PesNome.TrimEnd(' '), edtPesNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( cmbPesSituacao.isEventSource(eventSource) ) && ( ( A23PesSitu != cmbPesSituacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesTelefone.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A21PesTele.TrimEnd(' '), edtPesTelefone.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( cmbPesTipo.isEventSource(eventSource) ) && ( ( A38PesTipo != cmbPesTipo.getValue() ) ) )
         {
            return true;
         }
         if ( ( cmbPesFunCargo.isEventSource(eventSource) ) && ( ( A39PesFunC != cmbPesFunCargo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesFunDatDemissao.isEventSource(eventSource) ) && ( ( A41PesFunD != edtPesFunDatDemissao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesFunDatAdmissao.isEventSource(eventSource) ) && ( ( A42PesFunD != edtPesFunDatAdmissao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesFunLogin.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A43PesFunL.TrimEnd(' '), edtPesFunLogin.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesFunSenha.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A44PesFunS.TrimEnd(' '), edtPesFunSenha.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesFunSalario.isEventSource(eventSource) ) && ( ( A40PesFunS != edtPesFunSalario.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public override void resetCaption( )
      {
         ResetCaption070( ) ;
      }

      public override void setAddCaption( )
      {
      }

      public override bool getModeByParameter( )
      {
         return true ;
      }

      public override IGXButton getConfirmButton( )
      {
         return bttbtt47 ;
      }

      public bool promptHandler( Object eventSource )
      {
         if (( edtCidCodigo.isEventSource(eventSource) ) && ( edtCidCodigo.isEnabled() )) {
            prompt_26_1( ) ;
            return true ;
         }
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( edtCidCodigo.isEventSource(eventSource) )
         {
            edtCidCodigo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesBairro.isEventSource(eventSource) )
         {
            edtPesBairro.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesCelular.isEventSource(eventSource) )
         {
            edtPesCelular.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesCPF.isEventSource(eventSource) )
         {
            edtPesCPF.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesDatNascimento.isEventSource(eventSource) )
         {
            edtPesDatNascimento.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesEmail.isEventSource(eventSource) )
         {
            edtPesEmail.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesEndereco.isEventSource(eventSource) )
         {
            edtPesEndereco.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesEndNumero.isEventSource(eventSource) )
         {
            edtPesEndNumero.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesNome.isEventSource(eventSource) )
         {
            edtPesNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( cmbPesSituacao.isEventSource(eventSource) )
         {
            cmbPesSituacao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesTelefone.isEventSource(eventSource) )
         {
            edtPesTelefone.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( cmbPesFunCargo.isEventSource(eventSource) )
         {
            cmbPesFunCargo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesFunDatDemissao.isEventSource(eventSource) )
         {
            edtPesFunDatDemissao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesFunDatAdmissao.isEventSource(eventSource) )
         {
            edtPesFunDatAdmissao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesFunLogin.isEventSource(eventSource) )
         {
            edtPesFunLogin.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesFunSenha.isEventSource(eventSource) )
         {
            edtPesFunSenha.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesFunSalario.isEventSource(eventSource) )
         {
            edtPesFunSalario.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      public override void VariablesToControls( )
      {
         edtPesCodigo.setValue( A13PesCodi );
         edtEstCodigo.setValue( A24EstCodi );
         edtEstNome.setValue( A12EstNome );
         edtCidCodigo.setValue( A26CidCodi );
         edtEstUF.setValue( A25EstUF );
         edtCidNome.setValue( A27CidNome );
         edtPesBairro.setValue( A19PesBair );
         edtPesCelular.setValue( A22PesCelu );
         edtPesCPF.setValue( A15PesCPF );
         edtPesDatNascimento.setValue( A111PesDat );
         edtPesEmail.setValue( A20PesEmai );
         edtPesEndereco.setValue( A17PesEnde );
         edtPesEndNumero.setValue( A18PesEndN );
         edtPesNome.setValue( A14PesNome );
         cmbPesSituacao.setValue( A23PesSitu );
         edtPesTelefone.setValue( A21PesTele );
         cmbPesTipo.setValue( A38PesTipo );
         cmbPesFunCargo.setValue( A39PesFunC );
         edtPesFunDatDemissao.setValue( A41PesFunD );
         edtPesFunDatAdmissao.setValue( A42PesFunD );
         edtPesFunLogin.setValue( A43PesFunL );
         edtPesFunSenha.setValue( A44PesFunS );
         edtPesFunSalario.setValue( A40PesFunS );
      }

      public override void ControlsToVariables( )
      {
         A13PesCodi = (int)(edtPesCodigo.getValue()) ;
         edtPesCodigo.setValue(A13PesCodi);
         A24EstCodi = (int)(edtEstCodigo.getValue()) ;
         edtEstCodigo.setValue(A24EstCodi);
         n24EstCodi = false ;
         A12EstNome = (String)(edtEstNome.getValue()) ;
         edtEstNome.setValue(A12EstNome);
         n12EstNome = false ;
         A26CidCodi = (int)(edtCidCodigo.getValue()) ;
         edtCidCodigo.setValue(A26CidCodi);
         n26CidCodi = false ;
         n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
         A25EstUF = (String)(edtEstUF.getValue()) ;
         edtEstUF.setValue(A25EstUF);
         n25EstUF = false ;
         A27CidNome = (String)(edtCidNome.getValue()) ;
         edtCidNome.setValue(A27CidNome);
         n27CidNome = false ;
         A19PesBair = (String)(edtPesBairro.getValue()) ;
         edtPesBairro.setValue(A19PesBair);
         n19PesBair = false ;
         n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
         A22PesCelu = (String)(edtPesCelular.getValue()) ;
         edtPesCelular.setValue(A22PesCelu);
         n22PesCelu = false ;
         n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
         A15PesCPF = (String)(edtPesCPF.getValue()) ;
         edtPesCPF.setValue(A15PesCPF);
         n15PesCPF = false ;
         n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
         A111PesDat = (DateTime)(edtPesDatNascimento.getValue()) ;
         edtPesDatNascimento.setValue(A111PesDat);
         n111PesDat = false ;
         n111PesDat = (((DateTime.MinValue==A111PesDat)) ? true : false) ;
         A20PesEmai = (String)(edtPesEmail.getValue()) ;
         edtPesEmail.setValue(A20PesEmai);
         n20PesEmai = false ;
         n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
         A17PesEnde = (String)(edtPesEndereco.getValue()) ;
         edtPesEndereco.setValue(A17PesEnde);
         n17PesEnde = false ;
         n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
         A18PesEndN = (String)(edtPesEndNumero.getValue()) ;
         edtPesEndNumero.setValue(A18PesEndN);
         n18PesEndN = false ;
         n18PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
         A14PesNome = (String)(edtPesNome.getValue()) ;
         edtPesNome.setValue(A14PesNome);
         n14PesNome = false ;
         n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
         A23PesSitu = (short)(cmbPesSituacao.getValue()) ;
         cmbPesSituacao.setValue(A23PesSitu);
         n23PesSitu = false ;
         n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
         A21PesTele = (String)(edtPesTelefone.getValue()) ;
         edtPesTelefone.setValue(A21PesTele);
         n21PesTele = false ;
         n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
         A38PesTipo = (short)(cmbPesTipo.getValue()) ;
         cmbPesTipo.setValue(A38PesTipo);
         n38PesTipo = false ;
         n38PesTipo = (((0==A38PesTipo)) ? true : false) ;
         A39PesFunC = (short)(cmbPesFunCargo.getValue()) ;
         cmbPesFunCargo.setValue(A39PesFunC);
         n39PesFunC = false ;
         n39PesFunC = (((0==A39PesFunC)) ? true : false) ;
         A41PesFunD = (DateTime)(edtPesFunDatDemissao.getValue()) ;
         edtPesFunDatDemissao.setValue(A41PesFunD);
         n41PesFunD = false ;
         n41PesFunD = (((DateTime.MinValue==A41PesFunD)) ? true : false) ;
         A42PesFunD = (DateTime)(edtPesFunDatAdmissao.getValue()) ;
         edtPesFunDatAdmissao.setValue(A42PesFunD);
         n42PesFunD = false ;
         n42PesFunD = (((DateTime.MinValue==A42PesFunD)) ? true : false) ;
         A43PesFunL = (String)(edtPesFunLogin.getValue()) ;
         edtPesFunLogin.setValue(A43PesFunL);
         n43PesFunL = false ;
         n43PesFunL = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) ? true : false) ;
         A44PesFunS = (String)(edtPesFunSenha.getValue()) ;
         edtPesFunSenha.setValue(A44PesFunS);
         n44PesFunS = false ;
         n44PesFunS = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A44PesFunS).TrimEnd(' ') )==0)) ? true : false) ;
         A40PesFunS = (decimal)(edtPesFunSalario.getValue()) ;
         edtPesFunSalario.setValue(A40PesFunS);
         n40PesFunS = false ;
         n40PesFunS = (((Convert.ToDecimal(0M)==A40PesFunS)) ? true : false) ;
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
      }

      protected void eventLevelResetContext( )
      {
      }

      protected void reloadGridRow( )
      {
      }

      protected void prompt_26_1( )
      {
         new wgx0080(context, base.remoteHandle, base.context).execute( out  A26CidCodi) ;
         edtCidCodigo.setValue( A26CidCodi );
         n26CidCodi = false ;
         setFocus(edtCidCodigo);
         ResetCaption070( ) ;
      }

      protected void Valid_Pescodigo( )
      {
         if ( ( A13PesCodi != K13PesCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K13PesCodi = A13PesCodi ;
               getEqualNoModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
               {
                  StandaloneModalInsert( ) ;
               }
               VariablesToControls();
            }
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey = 0 ;
            }
            else
            {
               geteqAfterKey = 1 ;
            }
         }
         IsConfirmed = 0 ;
         set_caption( ) ;
      }

      protected void Valid_Pescpf( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "O CPF deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesCPF );
            setFocusNext();
         }
      }

      protected void Valid_Pesnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "O nome deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesNome );
            setFocusNext();
         }
      }

      protected void Valid_Pesdatnascimento( )
      {
         if ( ! ( ((DateTime.MinValue==A111PesDat)) || ( A111PesDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de nascimento da pessoa fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtPesDatNascimento );
            setFocusNext();
         }
      }

      protected void Valid_Pestelefone( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Número de telefone residencial não informado!" );
         }
      }

      protected void Valid_Pescelular( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Número de telefone celular não informado!" );
         }
      }

      protected void Valid_Estcodigo( )
      {
         /* Using cursor T00072 */
         pr_default.execute(0, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A24EstCodi)) ) )
            {
               GXutil.msg( me(), "Não existe 'Cadastro de Estados.'." );
               AnyError = 1 ;
               setNextFocus( edtEstCodigo );
               setFocusNext();
            }
         }
         A25EstUF = T00072_A25EstUF[0] ;
         n25EstUF = T00072_n25EstUF[0] ;
         A12EstNome = T00072_A12EstNome[0] ;
         n12EstNome = T00072_n12EstNome[0] ;
         pr_default.close(0);
         edtEstUF.setValue( A25EstUF );
         edtEstNome.setValue( A12EstNome );
         pr_default.close(0);
      }

      protected void Valid_Cidcodigo( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(1) == 101) )
         {
            if ( ! ( ((0==A26CidCodi)) ) )
            {
               GXutil.msg( me(), "Não existe 'Cadastro de cidades.'." );
               AnyError = 1 ;
               setNextFocus( edtCidCodigo );
               setFocusNext();
            }
         }
         A27CidNome = T00073_A27CidNome[0] ;
         n27CidNome = T00073_n27CidNome[0] ;
         A24EstCodi = T00073_A24EstCodi[0] ;
         n24EstCodi = T00073_n24EstCodi[0] ;
         pr_default.close(1);
         edtCidNome.setValue( A27CidNome );
         edtEstCodigo.setValue( A24EstCodi );
         if ( true /* After */ && ! ((0==A26CidCodi)) )
         {
            new pvercidcodigo(context, base.remoteHandle, base.context).execute(  A26CidCodi, out  AV7Erro) ;
         }
         if ( true /* After */ && ((0==A26CidCodi)) )
         {
            GXutil.msg( me(), "O código da cidade deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtCidCodigo );
            setFocusNext();
         }
         if ( true /* After */ && ! ((0==A26CidCodi)) && ( String.CompareOrdinal(AV7Erro.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
         {
            GXutil.msg( me(), "Informe um código de cidade válido!" );
            AnyError = 1 ;
            setNextFocus( edtCidCodigo );
            setFocusNext();
         }
         pr_default.close(1);
      }

      protected void Valid_Pesbairro( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Bairro não informado!" );
         }
      }

      protected void Valid_Pesendereco( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Endereço não informado!" );
         }
      }

      protected void Valid_Pesendnumero( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Número de endereço não informado!" );
         }
      }

      protected void Valid_Pesfunsalario( )
      {
         if ( true /* After */ && ((Convert.ToDecimal(0M)==A40PesFunS)) || ( A40PesFunS < Convert.ToDecimal( 0 )) )
         {
            GXutil.msg( me(), "O salário do funcionário deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesFunSalario );
            setFocusNext();
         }
      }

      protected void Valid_Pesfundatadmissao( )
      {
         if ( ! ( ((DateTime.MinValue==A42PesFunD)) || ( A42PesFunD >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de admissão do funcionário fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtPesFunDatAdmissao );
            setFocusNext();
         }
         if ( true /* After */ && ( A42PesFunD == DateTimeUtil.CToD( "0", 2) ) )
         {
            GXutil.msg( me(), "A data de admissão deve ser informada!" );
            AnyError = 1 ;
            setNextFocus( edtPesFunDatAdmissao );
            setFocusNext();
         }
      }

      protected void Valid_Pesfundatdemissao( )
      {
         if ( ! ( ((DateTime.MinValue==A41PesFunD)) || ( A41PesFunD >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de demissão do funcionário fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtPesFunDatDemissao );
            setFocusNext();
         }
      }

      protected void Valid_Pesfunlogin( )
      {
         if ( true /* After */ && ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) )
         {
            new pverpesfunlogin(context, base.remoteHandle, base.context).execute(  A43PesFunL,  A13PesCodi, out  AV7Erro) ;
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "O login deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesFunLogin );
            setFocusNext();
         }
      }

      protected void Valid_Pesfunsenha( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A44PesFunS).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "A senha deve ser informada!" );
            AnyError = 1 ;
            setNextFocus( edtPesFunSenha );
            setFocusNext();
         }
         reloadGridRow();
      }

      protected void E11072( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV7Erro = "N" ;
      }

      protected void E12072( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A26CidCodi") )
         {
            new wconscidade(context, base.remoteHandle, base.context).execute( out  A26CidCodi) ;
            edtCidCodigo.setValue( A26CidCodi );
            n26CidCodi = false ;
         }
         eventLevelResetContext();
      }

      /* Server side code */
      /* Aggregate/select formulas */
      /* Vertical formulas */
      public override void standaloneStartupServer( )
      {
         if ( ( AnyError == 0 ) )
         {
            standaloneNotModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
            {
               sMode1 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode1 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound1 != 1 ) )
               {
                  pushError( GXResourceManager.GetMessage("noinsert") );
                  AnyError = 1 ;
                  keepFocus();
               }
            }
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               i38PesTipo = A38PesTipo ;
            }
         }
         set_caption( ) ;
         PreviousCaption = bttbtt47.getCaption() ;
      }

      protected void ZM071( int GX_JID )
      {
         if ( ( GX_JID == 26 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z38PesTipo = T00075_A38PesTipo[0] ;
               Z14PesNome = T00075_A14PesNome[0] ;
               Z15PesCPF = T00075_A15PesCPF[0] ;
               Z111PesDat = T00075_A111PesDat[0] ;
               Z17PesEnde = T00075_A17PesEnde[0] ;
               Z18PesEndN = T00075_A18PesEndN[0] ;
               Z19PesBair = T00075_A19PesBair[0] ;
               Z20PesEmai = T00075_A20PesEmai[0] ;
               Z21PesTele = T00075_A21PesTele[0] ;
               Z22PesCelu = T00075_A22PesCelu[0] ;
               Z23PesSitu = T00075_A23PesSitu[0] ;
               Z39PesFunC = T00075_A39PesFunC[0] ;
               Z42PesFunD = T00075_A42PesFunD[0] ;
               Z41PesFunD = T00075_A41PesFunD[0] ;
               Z43PesFunL = T00075_A43PesFunL[0] ;
               Z44PesFunS = T00075_A44PesFunS[0] ;
               Z40PesFunS = T00075_A40PesFunS[0] ;
               Z26CidCodi = T00075_A26CidCodi[0] ;
            }
            else
            {
               Z38PesTipo = A38PesTipo ;
               Z14PesNome = A14PesNome ;
               Z15PesCPF = A15PesCPF ;
               Z111PesDat = A111PesDat ;
               Z17PesEnde = A17PesEnde ;
               Z18PesEndN = A18PesEndN ;
               Z19PesBair = A19PesBair ;
               Z20PesEmai = A20PesEmai ;
               Z21PesTele = A21PesTele ;
               Z22PesCelu = A22PesCelu ;
               Z23PesSitu = A23PesSitu ;
               Z39PesFunC = A39PesFunC ;
               Z42PesFunD = A42PesFunD ;
               Z41PesFunD = A41PesFunD ;
               Z43PesFunL = A43PesFunL ;
               Z44PesFunS = A44PesFunS ;
               Z40PesFunS = A40PesFunS ;
               Z26CidCodi = A26CidCodi ;
            }
         }
         if ( ( GX_JID == -26 ) )
         {
            Z13PesCodi = A13PesCodi ;
            Z38PesTipo = A38PesTipo ;
            Z14PesNome = A14PesNome ;
            Z15PesCPF = A15PesCPF ;
            Z111PesDat = A111PesDat ;
            Z17PesEnde = A17PesEnde ;
            Z18PesEndN = A18PesEndN ;
            Z19PesBair = A19PesBair ;
            Z20PesEmai = A20PesEmai ;
            Z21PesTele = A21PesTele ;
            Z22PesCelu = A22PesCelu ;
            Z23PesSitu = A23PesSitu ;
            Z39PesFunC = A39PesFunC ;
            Z42PesFunD = A42PesFunD ;
            Z41PesFunD = A41PesFunD ;
            Z43PesFunL = A43PesFunL ;
            Z44PesFunS = A44PesFunS ;
            Z40PesFunS = A40PesFunS ;
            Z26CidCodi = A26CidCodi ;
         }
      }

      public override void standaloneNotModal( )
      {
         cmbPesTipo.setEnabled(0);
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            edtPesCodigo.setEnabled(0);
         }
         else
         {
            edtPesCodigo.setEnabled(1);
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            edtPesFunLogin.setEnabled(0);
         }
         else
         {
            edtPesFunLogin.setEnabled(1);
         }
         if ( ( String.CompareOrdinal(AV7Erro.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
         {
            pushError( "O login informado já está em uso!" );
            AnyError = 1 ;
            keepFocus();
            sanomodError = 1 ;
         }
      }

      public override void standaloneModal( )
      {
         A38PesTipo = 2 ;
         cmbPesTipo.setValue(A38PesTipo);
         n38PesTipo = false ;
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
         }
      }

      protected void Load071( )
      {
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1 ;
            A38PesTipo = T00076_A38PesTipo[0] ;
            n38PesTipo = T00076_n38PesTipo[0] ;
            A14PesNome = T00076_A14PesNome[0] ;
            n14PesNome = T00076_n14PesNome[0] ;
            A15PesCPF = T00076_A15PesCPF[0] ;
            n15PesCPF = T00076_n15PesCPF[0] ;
            A111PesDat = T00076_A111PesDat[0] ;
            n111PesDat = T00076_n111PesDat[0] ;
            A25EstUF = T00076_A25EstUF[0] ;
            n25EstUF = T00076_n25EstUF[0] ;
            A17PesEnde = T00076_A17PesEnde[0] ;
            n17PesEnde = T00076_n17PesEnde[0] ;
            A12EstNome = T00076_A12EstNome[0] ;
            n12EstNome = T00076_n12EstNome[0] ;
            A27CidNome = T00076_A27CidNome[0] ;
            n27CidNome = T00076_n27CidNome[0] ;
            A18PesEndN = T00076_A18PesEndN[0] ;
            n18PesEndN = T00076_n18PesEndN[0] ;
            A19PesBair = T00076_A19PesBair[0] ;
            n19PesBair = T00076_n19PesBair[0] ;
            A20PesEmai = T00076_A20PesEmai[0] ;
            n20PesEmai = T00076_n20PesEmai[0] ;
            A21PesTele = T00076_A21PesTele[0] ;
            n21PesTele = T00076_n21PesTele[0] ;
            A22PesCelu = T00076_A22PesCelu[0] ;
            n22PesCelu = T00076_n22PesCelu[0] ;
            A23PesSitu = T00076_A23PesSitu[0] ;
            n23PesSitu = T00076_n23PesSitu[0] ;
            A39PesFunC = T00076_A39PesFunC[0] ;
            n39PesFunC = T00076_n39PesFunC[0] ;
            A42PesFunD = T00076_A42PesFunD[0] ;
            n42PesFunD = T00076_n42PesFunD[0] ;
            A41PesFunD = T00076_A41PesFunD[0] ;
            n41PesFunD = T00076_n41PesFunD[0] ;
            A43PesFunL = T00076_A43PesFunL[0] ;
            n43PesFunL = T00076_n43PesFunL[0] ;
            A44PesFunS = T00076_A44PesFunS[0] ;
            n44PesFunS = T00076_n44PesFunS[0] ;
            A40PesFunS = T00076_A40PesFunS[0] ;
            n40PesFunS = T00076_n40PesFunS[0] ;
            A26CidCodi = T00076_A26CidCodi[0] ;
            n26CidCodi = T00076_n26CidCodi[0] ;
            A24EstCodi = T00076_A24EstCodi[0] ;
            n24EstCodi = T00076_n24EstCodi[0] ;
            ZM071( -26) ;
         }
         pr_default.close(4);
         OnLoadActions071( ) ;
      }

      protected void OnLoadActions071( )
      {
      }

      protected void CheckExtendedTable071( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) )
         {
            pushError( "O CPF deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) )
         {
            pushError( "O nome deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ! ( ((DateTime.MinValue==A111PesDat)) || ( A111PesDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de nascimento da pessoa fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Número de telefone residencial não informado!" );
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Número de telefone celular não informado!" );
         }
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {n26CidCodi, A26CidCodi});
         if ( (pr_default.getStatus(1) == 101) )
         {
            if ( ! ( ((0==A26CidCodi)) ) )
            {
               pushError( "Não existe 'Cadastro de cidades.'." );
               AnyError = 1 ;
               setNextFocus( edtCidCodigo );
            }
         }
         A27CidNome = T00073_A27CidNome[0] ;
         n27CidNome = T00073_n27CidNome[0] ;
         A24EstCodi = T00073_A24EstCodi[0] ;
         n24EstCodi = T00073_n24EstCodi[0] ;
         pr_default.close(1);
         /* Using cursor T00072 */
         pr_default.execute(0, new Object[] {n24EstCodi, A24EstCodi});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A24EstCodi)) ) )
            {
               pushError( "Não existe 'Cadastro de Estados.'." );
               AnyError = 1 ;
               setNextFocus( edtEstCodigo );
            }
         }
         A25EstUF = T00072_A25EstUF[0] ;
         n25EstUF = T00072_n25EstUF[0] ;
         A12EstNome = T00072_A12EstNome[0] ;
         n12EstNome = T00072_n12EstNome[0] ;
         pr_default.close(0);
         if ( true /* After */ && ! ((0==A26CidCodi)) )
         {
            new pvercidcodigo(context, base.remoteHandle, base.context).execute(  A26CidCodi, out  AV7Erro) ;
         }
         if ( true /* After */ && ((0==A26CidCodi)) )
         {
            pushError( "O código da cidade deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ! ((0==A26CidCodi)) && ( String.CompareOrdinal(AV7Erro.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
         {
            pushError( "Informe um código de cidade válido!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Bairro não informado!" );
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Endereço não informado!" );
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Número de endereço não informado!" );
         }
         if ( true /* After */ && ((Convert.ToDecimal(0M)==A40PesFunS)) || ( A40PesFunS < Convert.ToDecimal( 0 )) )
         {
            pushError( "O salário do funcionário deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ! ( ((DateTime.MinValue==A42PesFunD)) || ( A42PesFunD >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de admissão do funcionário fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ( A42PesFunD == DateTimeUtil.CToD( "0", 2) ) )
         {
            pushError( "A data de admissão deve ser informada!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ! ( ((DateTime.MinValue==A41PesFunD)) || ( A41PesFunD >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de demissão do funcionário fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) )
         {
            new pverpesfunlogin(context, base.remoteHandle, base.context).execute(  A43PesFunL,  A13PesCodi, out  AV7Erro) ;
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A43PesFunL).TrimEnd(' ') )==0)) )
         {
            pushError( "O login deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A44PesFunS).TrimEnd(' ') )==0)) )
         {
            pushError( "A senha deve ser informada!" );
            AnyError = 1 ;
            keepFocus();
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors071( )
      {
         pr_default.close(1);
         pr_default.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey071( )
      {
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1 ;
         }
         else
         {
            RcdFound1 = 0 ;
         }
         pr_default.close(5);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(3) != 101) && ( T00075_A13PesCodi[0] == A13PesCodi ) )
         {
            ZM071( 26) ;
            RcdFound1 = 1 ;
            A38PesTipo = T00075_A38PesTipo[0] ;
            n38PesTipo = T00075_n38PesTipo[0] ;
            A14PesNome = T00075_A14PesNome[0] ;
            n14PesNome = T00075_n14PesNome[0] ;
            A15PesCPF = T00075_A15PesCPF[0] ;
            n15PesCPF = T00075_n15PesCPF[0] ;
            A111PesDat = T00075_A111PesDat[0] ;
            n111PesDat = T00075_n111PesDat[0] ;
            A17PesEnde = T00075_A17PesEnde[0] ;
            n17PesEnde = T00075_n17PesEnde[0] ;
            A18PesEndN = T00075_A18PesEndN[0] ;
            n18PesEndN = T00075_n18PesEndN[0] ;
            A19PesBair = T00075_A19PesBair[0] ;
            n19PesBair = T00075_n19PesBair[0] ;
            A20PesEmai = T00075_A20PesEmai[0] ;
            n20PesEmai = T00075_n20PesEmai[0] ;
            A21PesTele = T00075_A21PesTele[0] ;
            n21PesTele = T00075_n21PesTele[0] ;
            A22PesCelu = T00075_A22PesCelu[0] ;
            n22PesCelu = T00075_n22PesCelu[0] ;
            A23PesSitu = T00075_A23PesSitu[0] ;
            n23PesSitu = T00075_n23PesSitu[0] ;
            A39PesFunC = T00075_A39PesFunC[0] ;
            n39PesFunC = T00075_n39PesFunC[0] ;
            A42PesFunD = T00075_A42PesFunD[0] ;
            n42PesFunD = T00075_n42PesFunD[0] ;
            A41PesFunD = T00075_A41PesFunD[0] ;
            n41PesFunD = T00075_n41PesFunD[0] ;
            A43PesFunL = T00075_A43PesFunL[0] ;
            n43PesFunL = T00075_n43PesFunL[0] ;
            A44PesFunS = T00075_A44PesFunS[0] ;
            n44PesFunS = T00075_n44PesFunS[0] ;
            A40PesFunS = T00075_A40PesFunS[0] ;
            n40PesFunS = T00075_n40PesFunS[0] ;
            A26CidCodi = T00075_A26CidCodi[0] ;
            n26CidCodi = T00075_n26CidCodi[0] ;
            Z13PesCodi = A13PesCodi ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load071( ) ;
            Gx_mode = sMode1 ;
         }
         else
         {
            RcdFound1 = 0 ;
            InitializeNonKey071( ) ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode1 ;
         }
         K13PesCodi = A13PesCodi ;
         pr_default.close(3);
      }

      public override void getEqualNoModal( )
      {
         GetKey071( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T00078 */
         pr_default.execute(6, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( T00078_A13PesCodi[0] == A13PesCodi ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( T00078_A13PesCodi[0] == A13PesCodi ) )
            {
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T00079 */
         pr_default.execute(7, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( T00079_A13PesCodi[0] == A13PesCodi ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( T00079_A13PesCodi[0] == A13PesCodi ) )
            {
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(7);
      }

      public override void btn_enter( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            btn_delete( ) ;
            if	(loopOnce) cleanup();
            return  ;
         }
         nKeyPressed = 1 ;
         GetKey071( ) ;
         if ( ( RcdFound1 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtPesCodigo );
            }
            else if ( ( A13PesCodi != Z13PesCodi ) )
            {
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtPesCodigo );
            }
            else
            {
               /* Update record */
               Update071( ) ;
               setNextFocus( edtPesCodigo );
            }
         }
         else
         {
            if ( ( A13PesCodi != Z13PesCodi ) )
            {
               /* Insert record */
               Insert071( ) ;
               setNextFocus( edtPesCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtPesCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert071( ) ;
                  setNextFocus( edtPesCodigo );
               }
            }
         }
         handleErrors();
         AfterTrn( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
         AnyError = 0 ;
         if	(loopOnce) cleanup();
      }

      public override void btn_delete( )
      {
         if ( ( A13PesCodi != Z13PesCodi ) )
         {
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtPesCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtPesCodigo );
         }
         if ( ( AnyError != 0 ) )
         {
         }
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      protected void CheckOptimisticConcurrency071( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00074 */
            pr_default.execute(2, new Object[] {A13PesCodi});
            if ( ! (pr_default.getStatus(2) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"PESSOA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(2) == 101) || ( Z38PesTipo != T00074_A38PesTipo[0] ) || ( String.CompareOrdinal(Z14PesNome.TrimEnd(' '), T00074_A14PesNome[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z15PesCPF.TrimEnd(' '), T00074_A15PesCPF[0].TrimEnd(' ') ) != 0 ) || ( Z111PesDat != T00074_A111PesDat[0] ) || ( String.CompareOrdinal(Z17PesEnde.TrimEnd(' '), T00074_A17PesEnde[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( String.CompareOrdinal(Z18PesEndN.TrimEnd(' '), T00074_A18PesEndN[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z19PesBair.TrimEnd(' '), T00074_A19PesBair[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z20PesEmai.TrimEnd(' '), T00074_A20PesEmai[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z21PesTele.TrimEnd(' '), T00074_A21PesTele[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z22PesCelu.TrimEnd(' '), T00074_A22PesCelu[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z23PesSitu != T00074_A23PesSitu[0] ) || ( Z39PesFunC != T00074_A39PesFunC[0] ) || ( Z42PesFunD != T00074_A42PesFunD[0] ) || ( Z41PesFunD != T00074_A41PesFunD[0] ) || ( String.CompareOrdinal(Z43PesFunL.TrimEnd(' '), T00074_A43PesFunL[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( String.CompareOrdinal(Z44PesFunS.TrimEnd(' '), T00074_A44PesFunS[0].TrimEnd(' ') ) != 0 ) || ( Z40PesFunS != T00074_A40PesFunS[0] ) || ( Z26CidCodi != T00074_A26CidCodi[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"PESSOA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert071( )
      {
         BeforeValidate071( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable071( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM071( 0) ;
            CheckOptimisticConcurrency071( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm071( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert071( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000710 */
                     pr_default.execute(8, new Object[] {n38PesTipo, A38PesTipo, n14PesNome, A14PesNome, n15PesCPF, A15PesCPF, n111PesDat, A111PesDat, n17PesEnde, A17PesEnde, n18PesEndN, A18PesEndN, n19PesBair, A19PesBair, n20PesEmai, A20PesEmai, n21PesTele, A21PesTele, n22PesCelu, A22PesCelu, n23PesSitu, A23PesSitu, n39PesFunC, A39PesFunC, n42PesFunD, A42PesFunD, n41PesFunD, A41PesFunD, n43PesFunL, A43PesFunL, n44PesFunS, A44PesFunS, n40PesFunS, A40PesFunS, n26CidCodi, A26CidCodi});
                     pr_default.close(8);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000711 */
                     pr_default.execute(9);
                     A13PesCodi = T000711_A13PesCodi[0] ;
                     pr_default.close(9);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           loopOnce = true;
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
            else
            {
               Load071( ) ;
            }
            EndLevel071( ) ;
         }
         CloseExtendedTableCursors071( ) ;
      }

      protected void Update071( )
      {
         BeforeValidate071( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable071( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency071( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm071( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate071( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000712 */
                     pr_default.execute(10, new Object[] {n38PesTipo, A38PesTipo, n14PesNome, A14PesNome, n15PesCPF, A15PesCPF, n111PesDat, A111PesDat, n17PesEnde, A17PesEnde, n18PesEndN, A18PesEndN, n19PesBair, A19PesBair, n20PesEmai, A20PesEmai, n21PesTele, A21PesTele, n22PesCelu, A22PesCelu, n23PesSitu, A23PesSitu, n39PesFunC, A39PesFunC, n42PesFunD, A42PesFunD, n41PesFunD, A41PesFunD, n43PesFunL, A43PesFunL, n44PesFunS, A44PesFunS, n40PesFunS, A40PesFunS, n26CidCodi, A26CidCodi, A13PesCodi});
                     pr_default.close(10);
                     DeferredUpdate071( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           loopOnce = true;
                        }
                     }
                     else
                     {
                        pushError( GXResourceManager.GetMessage("unexp") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                  }
               }
            }
            EndLevel071( ) ;
         }
         CloseExtendedTableCursors071( ) ;
      }

      protected void DeferredUpdate071( )
      {
      }

      public override void delete( )
      {
         BeforeValidate071( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency071( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls071( ) ;
            /* No cascading delete specified. */
            AfterConfirm071( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete071( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000713 */
                  pr_default.execute(11, new Object[] {A13PesCodi});
                  pr_default.close(11);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        loopOnce = true;
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("unexp") );
                     AnyError = 1 ;
                     keepFocus();
                  }
               }
            }
         }
         sMode1 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel071( ) ;
         Gx_mode = sMode1 ;
      }

      protected void OnDeleteControls071( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000714 */
            pr_default.execute(12, new Object[] {n26CidCodi, A26CidCodi});
            A27CidNome = T000714_A27CidNome[0] ;
            n27CidNome = T000714_n27CidNome[0] ;
            A24EstCodi = T000714_A24EstCodi[0] ;
            n24EstCodi = T000714_n24EstCodi[0] ;
            pr_default.close(12);
            /* Using cursor T000715 */
            pr_default.execute(13, new Object[] {n24EstCodi, A24EstCodi});
            A25EstUF = T000715_A25EstUF[0] ;
            n25EstUF = T000715_n25EstUF[0] ;
            A12EstNome = T000715_A12EstNome[0] ;
            n12EstNome = T000715_n12EstNome[0] ;
            pr_default.close(13);
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000716 */
            pr_default.execute(14, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(14) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de locações."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(14);
            /* Using cursor T000717 */
            pr_default.execute(15, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(15) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de locações."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(15);
            /* Using cursor T000718 */
            pr_default.execute(16, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(16) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Dependente"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(16);
            /* Using cursor T000719 */
            pr_default.execute(17, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(17) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Dependente"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel071( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(2);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete071( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(3);
            pr_default.close(12);
            pr_default.close(13);
            context.CommitDataStores("TFuncionario");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(12);
            pr_default.close(13);
            context.RollbackDataStores("TFuncionario");
         }
         IsModified = 0 ;
      }

      protected void ScanStart071( )
      {
         /* Using cursor T000720 */
         pr_default.execute(18, new Object[] {A13PesCodi});
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound1 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext071( )
      {
         pr_default.readNext(18);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound1 = 1 ;
         }
      }

      protected void ScanEnd071( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm071( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert071( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate071( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete071( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete071( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate071( )
      {
         /* Before Validate Rules */
      }

      protected void CONFIRM_070( )
      {
         BeforeValidate071( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls071( ) ;
            }
            else
            {
               CheckExtendedTable071( ) ;
               CloseExtendedTableCursors071( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            PreviousCaption = bttbtt47.getCaption() ;
            PreviousTooltip = bttbtt47.getTooltip() ;
            IsConfirmed = 1 ;
         }
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(3);
         pr_default.close(12);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A38PesTipo = 0 ;
         n38PesTipo = false ;
         A14PesNome = "" ;
         n14PesNome = false ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         A111PesDat = (DateTime)(DateTime.MinValue) ;
         n111PesDat = false ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         A25EstUF = "" ;
         n25EstUF = false ;
         A17PesEnde = "" ;
         n17PesEnde = false ;
         A12EstNome = "" ;
         n12EstNome = false ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         A27CidNome = "" ;
         n27CidNome = false ;
         A18PesEndN = "" ;
         n18PesEndN = false ;
         A19PesBair = "" ;
         n19PesBair = false ;
         A20PesEmai = "" ;
         n20PesEmai = false ;
         A21PesTele = "" ;
         n21PesTele = false ;
         A22PesCelu = "" ;
         n22PesCelu = false ;
         A23PesSitu = 0 ;
         n23PesSitu = false ;
         A39PesFunC = 0 ;
         n39PesFunC = false ;
         A42PesFunD = (DateTime)(DateTime.MinValue) ;
         n42PesFunD = false ;
         A41PesFunD = (DateTime)(DateTime.MinValue) ;
         n41PesFunD = false ;
         A43PesFunL = "" ;
         n43PesFunL = false ;
         A44PesFunS = "" ;
         n44PesFunS = false ;
         A40PesFunS = (decimal)(0M) ;
         n40PesFunS = false ;
         i38PesTipo = 0 ;
         lastAnyError = 0 ;
         scmdbuf = "" ;
         T00072_A25EstUF = new String[] {""} ;
         T00072_n25EstUF = new bool[] {false} ;
         T00072_A12EstNome = new String[] {""} ;
         T00072_n12EstNome = new bool[] {false} ;
         T00073_A27CidNome = new String[] {""} ;
         T00073_n27CidNome = new bool[] {false} ;
         T00073_A24EstCodi = new int[1] ;
         T00073_n24EstCodi = new bool[] {false} ;
         AV7Erro = "" ;
         sMode1 = "" ;
         RcdFound1 = 0 ;
         Z38PesTipo = 0 ;
         Z14PesNome = "" ;
         Z15PesCPF = "" ;
         Z111PesDat = (DateTime)(DateTime.MinValue) ;
         Z17PesEnde = "" ;
         Z18PesEndN = "" ;
         Z19PesBair = "" ;
         Z20PesEmai = "" ;
         Z21PesTele = "" ;
         Z22PesCelu = "" ;
         Z23PesSitu = 0 ;
         Z39PesFunC = 0 ;
         Z42PesFunD = (DateTime)(DateTime.MinValue) ;
         Z41PesFunD = (DateTime)(DateTime.MinValue) ;
         Z43PesFunL = "" ;
         Z44PesFunS = "" ;
         Z40PesFunS = (decimal)(0M) ;
         Z26CidCodi = 0 ;
         GX_JID = 0 ;
         Z13PesCodi = 0 ;
         T00076_A13PesCodi = new int[1] ;
         T00076_A38PesTipo = new short[1] ;
         T00076_n38PesTipo = new bool[] {false} ;
         T00076_A14PesNome = new String[] {""} ;
         T00076_n14PesNome = new bool[] {false} ;
         T00076_A15PesCPF = new String[] {""} ;
         T00076_n15PesCPF = new bool[] {false} ;
         T00076_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         T00076_n111PesDat = new bool[] {false} ;
         T00076_A25EstUF = new String[] {""} ;
         T00076_n25EstUF = new bool[] {false} ;
         T00076_A17PesEnde = new String[] {""} ;
         T00076_n17PesEnde = new bool[] {false} ;
         T00076_A12EstNome = new String[] {""} ;
         T00076_n12EstNome = new bool[] {false} ;
         T00076_A27CidNome = new String[] {""} ;
         T00076_n27CidNome = new bool[] {false} ;
         T00076_A18PesEndN = new String[] {""} ;
         T00076_n18PesEndN = new bool[] {false} ;
         T00076_A19PesBair = new String[] {""} ;
         T00076_n19PesBair = new bool[] {false} ;
         T00076_A20PesEmai = new String[] {""} ;
         T00076_n20PesEmai = new bool[] {false} ;
         T00076_A21PesTele = new String[] {""} ;
         T00076_n21PesTele = new bool[] {false} ;
         T00076_A22PesCelu = new String[] {""} ;
         T00076_n22PesCelu = new bool[] {false} ;
         T00076_A23PesSitu = new short[1] ;
         T00076_n23PesSitu = new bool[] {false} ;
         T00076_A39PesFunC = new short[1] ;
         T00076_n39PesFunC = new bool[] {false} ;
         T00076_A42PesFunD = new DateTime[] {DateTime.MinValue} ;
         T00076_n42PesFunD = new bool[] {false} ;
         T00076_A41PesFunD = new DateTime[] {DateTime.MinValue} ;
         T00076_n41PesFunD = new bool[] {false} ;
         T00076_A43PesFunL = new String[] {""} ;
         T00076_n43PesFunL = new bool[] {false} ;
         T00076_A44PesFunS = new String[] {""} ;
         T00076_n44PesFunS = new bool[] {false} ;
         T00076_A40PesFunS = new decimal[1] ;
         T00076_n40PesFunS = new bool[] {false} ;
         T00076_A26CidCodi = new int[1] ;
         T00076_n26CidCodi = new bool[] {false} ;
         T00076_A24EstCodi = new int[1] ;
         T00076_n24EstCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T00077_A13PesCodi = new int[1] ;
         T00075_A13PesCodi = new int[1] ;
         T00075_A38PesTipo = new short[1] ;
         T00075_n38PesTipo = new bool[] {false} ;
         T00075_A14PesNome = new String[] {""} ;
         T00075_n14PesNome = new bool[] {false} ;
         T00075_A15PesCPF = new String[] {""} ;
         T00075_n15PesCPF = new bool[] {false} ;
         T00075_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         T00075_n111PesDat = new bool[] {false} ;
         T00075_A17PesEnde = new String[] {""} ;
         T00075_n17PesEnde = new bool[] {false} ;
         T00075_A18PesEndN = new String[] {""} ;
         T00075_n18PesEndN = new bool[] {false} ;
         T00075_A19PesBair = new String[] {""} ;
         T00075_n19PesBair = new bool[] {false} ;
         T00075_A20PesEmai = new String[] {""} ;
         T00075_n20PesEmai = new bool[] {false} ;
         T00075_A21PesTele = new String[] {""} ;
         T00075_n21PesTele = new bool[] {false} ;
         T00075_A22PesCelu = new String[] {""} ;
         T00075_n22PesCelu = new bool[] {false} ;
         T00075_A23PesSitu = new short[1] ;
         T00075_n23PesSitu = new bool[] {false} ;
         T00075_A39PesFunC = new short[1] ;
         T00075_n39PesFunC = new bool[] {false} ;
         T00075_A42PesFunD = new DateTime[] {DateTime.MinValue} ;
         T00075_n42PesFunD = new bool[] {false} ;
         T00075_A41PesFunD = new DateTime[] {DateTime.MinValue} ;
         T00075_n41PesFunD = new bool[] {false} ;
         T00075_A43PesFunL = new String[] {""} ;
         T00075_n43PesFunL = new bool[] {false} ;
         T00075_A44PesFunS = new String[] {""} ;
         T00075_n44PesFunS = new bool[] {false} ;
         T00075_A40PesFunS = new decimal[1] ;
         T00075_n40PesFunS = new bool[] {false} ;
         T00075_A26CidCodi = new int[1] ;
         T00075_n26CidCodi = new bool[] {false} ;
         T00078_A13PesCodi = new int[1] ;
         T00079_A13PesCodi = new int[1] ;
         T00074_A13PesCodi = new int[1] ;
         T00074_A38PesTipo = new short[1] ;
         T00074_n38PesTipo = new bool[] {false} ;
         T00074_A14PesNome = new String[] {""} ;
         T00074_n14PesNome = new bool[] {false} ;
         T00074_A15PesCPF = new String[] {""} ;
         T00074_n15PesCPF = new bool[] {false} ;
         T00074_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         T00074_n111PesDat = new bool[] {false} ;
         T00074_A17PesEnde = new String[] {""} ;
         T00074_n17PesEnde = new bool[] {false} ;
         T00074_A18PesEndN = new String[] {""} ;
         T00074_n18PesEndN = new bool[] {false} ;
         T00074_A19PesBair = new String[] {""} ;
         T00074_n19PesBair = new bool[] {false} ;
         T00074_A20PesEmai = new String[] {""} ;
         T00074_n20PesEmai = new bool[] {false} ;
         T00074_A21PesTele = new String[] {""} ;
         T00074_n21PesTele = new bool[] {false} ;
         T00074_A22PesCelu = new String[] {""} ;
         T00074_n22PesCelu = new bool[] {false} ;
         T00074_A23PesSitu = new short[1] ;
         T00074_n23PesSitu = new bool[] {false} ;
         T00074_A39PesFunC = new short[1] ;
         T00074_n39PesFunC = new bool[] {false} ;
         T00074_A42PesFunD = new DateTime[] {DateTime.MinValue} ;
         T00074_n42PesFunD = new bool[] {false} ;
         T00074_A41PesFunD = new DateTime[] {DateTime.MinValue} ;
         T00074_n41PesFunD = new bool[] {false} ;
         T00074_A43PesFunL = new String[] {""} ;
         T00074_n43PesFunL = new bool[] {false} ;
         T00074_A44PesFunS = new String[] {""} ;
         T00074_n44PesFunS = new bool[] {false} ;
         T00074_A40PesFunS = new decimal[1] ;
         T00074_n40PesFunS = new bool[] {false} ;
         T00074_A26CidCodi = new int[1] ;
         T00074_n26CidCodi = new bool[] {false} ;
         Gx_longc = false ;
         T000711_A13PesCodi = new int[1] ;
         T000714_A27CidNome = new String[] {""} ;
         T000714_n27CidNome = new bool[] {false} ;
         T000714_A24EstCodi = new int[1] ;
         T000714_n24EstCodi = new bool[] {false} ;
         T000715_A25EstUF = new String[] {""} ;
         T000715_n25EstUF = new bool[] {false} ;
         T000715_A12EstNome = new String[] {""} ;
         T000715_n12EstNome = new bool[] {false} ;
         T000716_A86LocCodi = new int[1] ;
         T000717_A86LocCodi = new int[1] ;
         T000718_A13PesCodi = new int[1] ;
         T000718_A46PesDepC = new int[1] ;
         T000719_A13PesCodi = new int[1] ;
         T000719_A46PesDepC = new int[1] ;
         T000720_A13PesCodi = new int[1] ;
         K13PesCodi = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tfuncionario__default(),
            new Object[][] {
                new Object[] {
               T00072_A25EstUF, T00072_n25EstUF, T00072_A12EstNome, T00072_n12EstNome
               }
               , new Object[] {
               T00073_A27CidNome, T00073_n27CidNome, T00073_A24EstCodi, T00073_n24EstCodi
               }
               , new Object[] {
               T00074_A13PesCodi, T00074_A38PesTipo, T00074_n38PesTipo, T00074_A14PesNome, T00074_n14PesNome, T00074_A15PesCPF, T00074_n15PesCPF, T00074_A111PesDat, T00074_n111PesDat, T00074_A17PesEnde,
               T00074_n17PesEnde, T00074_A18PesEndN, T00074_n18PesEndN, T00074_A19PesBair, T00074_n19PesBair, T00074_A20PesEmai, T00074_n20PesEmai, T00074_A21PesTele, T00074_n21PesTele, T00074_A22PesCelu,
               T00074_n22PesCelu, T00074_A23PesSitu, T00074_n23PesSitu, T00074_A39PesFunC, T00074_n39PesFunC, T00074_A42PesFunD, T00074_n42PesFunD, T00074_A41PesFunD, T00074_n41PesFunD, T00074_A43PesFunL,
               T00074_n43PesFunL, T00074_A44PesFunS, T00074_n44PesFunS, T00074_A40PesFunS, T00074_n40PesFunS, T00074_A26CidCodi, T00074_n26CidCodi
               }
               , new Object[] {
               T00075_A13PesCodi, T00075_A38PesTipo, T00075_n38PesTipo, T00075_A14PesNome, T00075_n14PesNome, T00075_A15PesCPF, T00075_n15PesCPF, T00075_A111PesDat, T00075_n111PesDat, T00075_A17PesEnde,
               T00075_n17PesEnde, T00075_A18PesEndN, T00075_n18PesEndN, T00075_A19PesBair, T00075_n19PesBair, T00075_A20PesEmai, T00075_n20PesEmai, T00075_A21PesTele, T00075_n21PesTele, T00075_A22PesCelu,
               T00075_n22PesCelu, T00075_A23PesSitu, T00075_n23PesSitu, T00075_A39PesFunC, T00075_n39PesFunC, T00075_A42PesFunD, T00075_n42PesFunD, T00075_A41PesFunD, T00075_n41PesFunD, T00075_A43PesFunL,
               T00075_n43PesFunL, T00075_A44PesFunS, T00075_n44PesFunS, T00075_A40PesFunS, T00075_n40PesFunS, T00075_A26CidCodi, T00075_n26CidCodi
               }
               , new Object[] {
               T00076_A13PesCodi, T00076_A38PesTipo, T00076_n38PesTipo, T00076_A14PesNome, T00076_n14PesNome, T00076_A15PesCPF, T00076_n15PesCPF, T00076_A111PesDat, T00076_n111PesDat, T00076_A25EstUF,
               T00076_n25EstUF, T00076_A17PesEnde, T00076_n17PesEnde, T00076_A12EstNome, T00076_n12EstNome, T00076_A27CidNome, T00076_n27CidNome, T00076_A18PesEndN, T00076_n18PesEndN, T00076_A19PesBair,
               T00076_n19PesBair, T00076_A20PesEmai, T00076_n20PesEmai, T00076_A21PesTele, T00076_n21PesTele, T00076_A22PesCelu, T00076_n22PesCelu, T00076_A23PesSitu, T00076_n23PesSitu, T00076_A39PesFunC,
               T00076_n39PesFunC, T00076_A42PesFunD, T00076_n42PesFunD, T00076_A41PesFunD, T00076_n41PesFunD, T00076_A43PesFunL, T00076_n43PesFunL, T00076_A44PesFunS, T00076_n44PesFunS, T00076_A40PesFunS,
               T00076_n40PesFunS, T00076_A26CidCodi, T00076_n26CidCodi, T00076_A24EstCodi, T00076_n24EstCodi
               }
               , new Object[] {
               T00077_A13PesCodi
               }
               , new Object[] {
               T00078_A13PesCodi
               }
               , new Object[] {
               T00079_A13PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000711_A13PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000714_A27CidNome, T000714_n27CidNome, T000714_A24EstCodi, T000714_n24EstCodi
               }
               , new Object[] {
               T000715_A25EstUF, T000715_n25EstUF, T000715_A12EstNome, T000715_n12EstNome
               }
               , new Object[] {
               T000716_A86LocCodi
               }
               , new Object[] {
               T000717_A86LocCodi
               }
               , new Object[] {
               T000718_A13PesCodi, T000718_A46PesDepC
               }
               , new Object[] {
               T000719_A13PesCodi, T000719_A46PesDepC
               }
               , new Object[] {
               T000720_A13PesCodi
               }
            }
         );
         reloadDynamicLists(0);
         K13PesCodi = 0 ;
         edtPesCodigo.setValue(A13PesCodi);
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A38PesTipo ;
      protected short A23PesSitu ;
      protected short A39PesFunC ;
      protected short geteqAfterKey= 1 ;
      protected short i38PesTipo ;
      protected short RcdFound1 ;
      protected short Z38PesTipo ;
      protected short Z23PesSitu ;
      protected short Z39PesFunC ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int A24EstCodi ;
      protected int A26CidCodi ;
      protected int K13PesCodi ;
      protected int A13PesCodi ;
      protected int lastAnyError ;
      protected int Z26CidCodi ;
      protected int GX_JID ;
      protected int Z13PesCodi ;
      protected decimal A40PesFunS ;
      protected decimal Z40PesFunS ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String A25EstUF ;
      protected String scmdbuf ;
      protected String AV7Erro ;
      protected String sMode1 ;
      protected DateTime A111PesDat ;
      protected DateTime A42PesFunD ;
      protected DateTime A41PesFunD ;
      protected DateTime Z111PesDat ;
      protected DateTime Z42PesFunD ;
      protected DateTime Z41PesFunD ;
      protected bool n38PesTipo ;
      protected bool n14PesNome ;
      protected bool n15PesCPF ;
      protected bool n111PesDat ;
      protected bool n24EstCodi ;
      protected bool n25EstUF ;
      protected bool n17PesEnde ;
      protected bool n12EstNome ;
      protected bool n26CidCodi ;
      protected bool n27CidNome ;
      protected bool n18PesEndN ;
      protected bool n19PesBair ;
      protected bool n20PesEmai ;
      protected bool n21PesTele ;
      protected bool n22PesCelu ;
      protected bool n23PesSitu ;
      protected bool n39PesFunC ;
      protected bool n42PesFunD ;
      protected bool n41PesFunD ;
      protected bool n43PesFunL ;
      protected bool n44PesFunS ;
      protected bool n40PesFunS ;
      protected bool Gx_longc ;
      protected String A14PesNome ;
      protected String A15PesCPF ;
      protected String A17PesEnde ;
      protected String A12EstNome ;
      protected String A27CidNome ;
      protected String A18PesEndN ;
      protected String A19PesBair ;
      protected String A20PesEmai ;
      protected String A21PesTele ;
      protected String A22PesCelu ;
      protected String A43PesFunL ;
      protected String A44PesFunS ;
      protected String Z14PesNome ;
      protected String Z15PesCPF ;
      protected String Z17PesEnde ;
      protected String Z18PesEndN ;
      protected String Z19PesBair ;
      protected String Z20PesEmai ;
      protected String Z21PesTele ;
      protected String Z22PesCelu ;
      protected String Z43PesFunL ;
      protected String Z44PesFunS ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtPesCodigo ;
      protected GUIObjectString edtPesCPF ;
      protected GUIObjectString edtPesNome ;
      protected GUIObjectDatetime edtPesDatNascimento ;
      protected GUIObjectShort cmbPesSituacao ;
      protected GUIObjectString edtPesTelefone ;
      protected GUIObjectShort cmbPesTipo ;
      protected GUIObjectString edtPesCelular ;
      protected GUIObjectString edtPesEmail ;
      protected GUIObjectInt edtEstCodigo ;
      protected GUIObjectString edtEstNome ;
      protected GUIObjectString edtEstUF ;
      protected GUIObjectInt edtCidCodigo ;
      protected GUIObjectString edtCidNome ;
      protected GUIObjectString edtPesBairro ;
      protected GUIObjectString edtPesEndereco ;
      protected GUIObjectString edtPesEndNumero ;
      protected GUIObjectShort cmbPesFunCargo ;
      protected GUIObjectDecimal2 edtPesFunSalario ;
      protected GUIObjectDatetime edtPesFunDatAdmissao ;
      protected GUIObjectDatetime edtPesFunDatDemissao ;
      protected GUIObjectString edtPesFunLogin ;
      protected GUIObjectString edtPesFunSenha ;
      protected IGXButton bttbtt47 ;
      protected ILabel lbllbl48 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl19 ;
      protected ILabel lbllbl29 ;
      protected ILabel lbllbl21 ;
      protected ILabel lbllbl31 ;
      protected ILabel lbllbl33 ;
      protected ILabel lbllbl35 ;
      protected ILabel lbllbl17 ;
      protected ILabel lbllbl23 ;
      protected ILabel lbllbl5 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl25 ;
      protected ILabel lbllbl27 ;
      protected ILabel lbllbl37 ;
      protected ILabel lbllbl46 ;
      protected ILabel lbllbl41 ;
      protected ILabel lbllbl39 ;
      protected ILabel lbllbl43 ;
      protected ILabel lbllbl45 ;
      protected IGXRectangle rctrct50 ;
      protected IDataReader T00072 ;
      protected IDataStoreProvider pr_default ;
      protected String[] T00072_A25EstUF ;
      protected bool[] T00072_n25EstUF ;
      protected String[] T00072_A12EstNome ;
      protected bool[] T00072_n12EstNome ;
      protected IDataReader T00073 ;
      protected String[] T00073_A27CidNome ;
      protected bool[] T00073_n27CidNome ;
      protected int[] T00073_A24EstCodi ;
      protected bool[] T00073_n24EstCodi ;
      protected IDataReader T00074 ;
      protected IDataReader T00075 ;
      protected IDataReader T00076 ;
      protected int[] T00076_A13PesCodi ;
      protected short[] T00076_A38PesTipo ;
      protected bool[] T00076_n38PesTipo ;
      protected String[] T00076_A14PesNome ;
      protected bool[] T00076_n14PesNome ;
      protected String[] T00076_A15PesCPF ;
      protected bool[] T00076_n15PesCPF ;
      protected DateTime[] T00076_A111PesDat ;
      protected bool[] T00076_n111PesDat ;
      protected String[] T00076_A25EstUF ;
      protected bool[] T00076_n25EstUF ;
      protected String[] T00076_A17PesEnde ;
      protected bool[] T00076_n17PesEnde ;
      protected String[] T00076_A12EstNome ;
      protected bool[] T00076_n12EstNome ;
      protected String[] T00076_A27CidNome ;
      protected bool[] T00076_n27CidNome ;
      protected String[] T00076_A18PesEndN ;
      protected bool[] T00076_n18PesEndN ;
      protected String[] T00076_A19PesBair ;
      protected bool[] T00076_n19PesBair ;
      protected String[] T00076_A20PesEmai ;
      protected bool[] T00076_n20PesEmai ;
      protected String[] T00076_A21PesTele ;
      protected bool[] T00076_n21PesTele ;
      protected String[] T00076_A22PesCelu ;
      protected bool[] T00076_n22PesCelu ;
      protected short[] T00076_A23PesSitu ;
      protected bool[] T00076_n23PesSitu ;
      protected short[] T00076_A39PesFunC ;
      protected bool[] T00076_n39PesFunC ;
      protected DateTime[] T00076_A42PesFunD ;
      protected bool[] T00076_n42PesFunD ;
      protected DateTime[] T00076_A41PesFunD ;
      protected bool[] T00076_n41PesFunD ;
      protected String[] T00076_A43PesFunL ;
      protected bool[] T00076_n43PesFunL ;
      protected String[] T00076_A44PesFunS ;
      protected bool[] T00076_n44PesFunS ;
      protected decimal[] T00076_A40PesFunS ;
      protected bool[] T00076_n40PesFunS ;
      protected int[] T00076_A26CidCodi ;
      protected bool[] T00076_n26CidCodi ;
      protected int[] T00076_A24EstCodi ;
      protected bool[] T00076_n24EstCodi ;
      protected IDataReader T00077 ;
      protected int[] T00077_A13PesCodi ;
      protected int[] T00075_A13PesCodi ;
      protected short[] T00075_A38PesTipo ;
      protected bool[] T00075_n38PesTipo ;
      protected String[] T00075_A14PesNome ;
      protected bool[] T00075_n14PesNome ;
      protected String[] T00075_A15PesCPF ;
      protected bool[] T00075_n15PesCPF ;
      protected DateTime[] T00075_A111PesDat ;
      protected bool[] T00075_n111PesDat ;
      protected String[] T00075_A17PesEnde ;
      protected bool[] T00075_n17PesEnde ;
      protected String[] T00075_A18PesEndN ;
      protected bool[] T00075_n18PesEndN ;
      protected String[] T00075_A19PesBair ;
      protected bool[] T00075_n19PesBair ;
      protected String[] T00075_A20PesEmai ;
      protected bool[] T00075_n20PesEmai ;
      protected String[] T00075_A21PesTele ;
      protected bool[] T00075_n21PesTele ;
      protected String[] T00075_A22PesCelu ;
      protected bool[] T00075_n22PesCelu ;
      protected short[] T00075_A23PesSitu ;
      protected bool[] T00075_n23PesSitu ;
      protected short[] T00075_A39PesFunC ;
      protected bool[] T00075_n39PesFunC ;
      protected DateTime[] T00075_A42PesFunD ;
      protected bool[] T00075_n42PesFunD ;
      protected DateTime[] T00075_A41PesFunD ;
      protected bool[] T00075_n41PesFunD ;
      protected String[] T00075_A43PesFunL ;
      protected bool[] T00075_n43PesFunL ;
      protected String[] T00075_A44PesFunS ;
      protected bool[] T00075_n44PesFunS ;
      protected decimal[] T00075_A40PesFunS ;
      protected bool[] T00075_n40PesFunS ;
      protected int[] T00075_A26CidCodi ;
      protected bool[] T00075_n26CidCodi ;
      protected IDataReader T00078 ;
      protected int[] T00078_A13PesCodi ;
      protected IDataReader T00079 ;
      protected int[] T00079_A13PesCodi ;
      protected int[] T00074_A13PesCodi ;
      protected short[] T00074_A38PesTipo ;
      protected bool[] T00074_n38PesTipo ;
      protected String[] T00074_A14PesNome ;
      protected bool[] T00074_n14PesNome ;
      protected String[] T00074_A15PesCPF ;
      protected bool[] T00074_n15PesCPF ;
      protected DateTime[] T00074_A111PesDat ;
      protected bool[] T00074_n111PesDat ;
      protected String[] T00074_A17PesEnde ;
      protected bool[] T00074_n17PesEnde ;
      protected String[] T00074_A18PesEndN ;
      protected bool[] T00074_n18PesEndN ;
      protected String[] T00074_A19PesBair ;
      protected bool[] T00074_n19PesBair ;
      protected String[] T00074_A20PesEmai ;
      protected bool[] T00074_n20PesEmai ;
      protected String[] T00074_A21PesTele ;
      protected bool[] T00074_n21PesTele ;
      protected String[] T00074_A22PesCelu ;
      protected bool[] T00074_n22PesCelu ;
      protected short[] T00074_A23PesSitu ;
      protected bool[] T00074_n23PesSitu ;
      protected short[] T00074_A39PesFunC ;
      protected bool[] T00074_n39PesFunC ;
      protected DateTime[] T00074_A42PesFunD ;
      protected bool[] T00074_n42PesFunD ;
      protected DateTime[] T00074_A41PesFunD ;
      protected bool[] T00074_n41PesFunD ;
      protected String[] T00074_A43PesFunL ;
      protected bool[] T00074_n43PesFunL ;
      protected String[] T00074_A44PesFunS ;
      protected bool[] T00074_n44PesFunS ;
      protected decimal[] T00074_A40PesFunS ;
      protected bool[] T00074_n40PesFunS ;
      protected int[] T00074_A26CidCodi ;
      protected bool[] T00074_n26CidCodi ;
      protected IDataReader T000711 ;
      protected int[] T000711_A13PesCodi ;
      protected IDataReader T000714 ;
      protected String[] T000714_A27CidNome ;
      protected bool[] T000714_n27CidNome ;
      protected int[] T000714_A24EstCodi ;
      protected bool[] T000714_n24EstCodi ;
      protected IDataReader T000715 ;
      protected String[] T000715_A25EstUF ;
      protected bool[] T000715_n25EstUF ;
      protected String[] T000715_A12EstNome ;
      protected bool[] T000715_n12EstNome ;
      protected IDataReader T000716 ;
      protected int[] T000716_A86LocCodi ;
      protected IDataReader T000717 ;
      protected int[] T000717_A86LocCodi ;
      protected IDataReader T000718 ;
      protected int[] T000718_A13PesCodi ;
      protected int[] T000718_A46PesDepC ;
      protected IDataReader T000719 ;
      protected int[] T000719_A13PesCodi ;
      protected int[] T000719_A46PesDepC ;
      protected IDataReader T000720 ;
      protected int[] T000720_A13PesCodi ;
   }

   public class tfuncionario__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[3])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[4])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[5])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[6])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[7])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[14])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[15])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[16])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[17])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[18])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          new Object[] {"@PesTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesDatNascimento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesEndereco",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEndNumero",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesBairro",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PesTelefone",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesCelular",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PesFunCargo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PesFunDatAdmissao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesFunDatDemissao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesFunLogin",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesFunSenha",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesFunSalario",SqlDbType.Decimal,12,2} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          } ;
          Object[] prmT000712 ;
          prmT000712 = new Object[] {
          new Object[] {"@PesTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesDatNascimento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesEndereco",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEndNumero",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesBairro",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PesTelefone",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesCelular",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PesFunCargo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PesFunDatAdmissao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesFunDatDemissao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesFunLogin",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesFunSenha",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesFunSalario",SqlDbType.Decimal,12,2} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000713 ;
          prmT000713 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000714 ;
          prmT000714 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000715 ;
          prmT000715 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000716 ;
          prmT000716 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000717 ;
          prmT000717 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000718 ;
          prmT000718 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000719 ;
          prmT000719 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000720 ;
          prmT000720 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00072", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00073", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00074", "SELECT [PesCodigo], [PesTipo], [PesNome], [PesCPF], [PesDatNascimento], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [PesFunCargo], [PesFunDatAdmissao], [PesFunDatDemissao], [PesFunLogin], [PesFunSenha], [PesFunSalario], [CidCodigo] FROM [PESSOA] WITH (UPDLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00075", "SELECT [PesCodigo], [PesTipo], [PesNome], [PesCPF], [PesDatNascimento], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [PesFunCargo], [PesFunDatAdmissao], [PesFunDatDemissao], [PesFunLogin], [PesFunSenha], [PesFunSalario], [CidCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00076", "SELECT TM1.[PesCodigo], TM1.[PesTipo], TM1.[PesNome], TM1.[PesCPF], TM1.[PesDatNascimento], T3.[EstUF], TM1.[PesEndereco], T3.[EstNome], T2.[CidNome], TM1.[PesEndNumero], TM1.[PesBairro], TM1.[PesEmail], TM1.[PesTelefone], TM1.[PesCelular], TM1.[PesSituacao], TM1.[PesFunCargo], TM1.[PesFunDatAdmissao], TM1.[PesFunDatDemissao], TM1.[PesFunLogin], TM1.[PesFunSenha], TM1.[PesFunSalario], TM1.[CidCodigo], T2.[EstCodigo] FROM (([PESSOA] TM1 WITH (NOLOCK) LEFT JOIN [CIDADE] T2 WITH (NOLOCK) ON T2.[CidCodigo] = TM1.[CidCodigo]) LEFT JOIN [ESTADO] T3 WITH (NOLOCK) ON T3.[EstCodigo] = T2.[EstCodigo]) WHERE TM1.[PesCodigo] = @PesCodigo ORDER BY TM1.[PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00077", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00078", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00079", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00079,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000710", "INSERT INTO [PESSOA] ([PesTipo], [PesNome], [PesCPF], [PesDatNascimento], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [PesFunCargo], [PesFunDatAdmissao], [PesFunDatDemissao], [PesFunLogin], [PesFunSenha], [PesFunSalario], [CidCodigo], [Depende], [DepValidacao]) VALUES (@PesTipo, @PesNome, @PesCPF, @PesDatNascimento, @PesEndereco, @PesEndNumero, @PesBairro, @PesEmail, @PesTelefone, @PesCelular, @PesSituacao, @PesFunCargo, @PesFunDatAdmissao, @PesFunDatDemissao, @PesFunLogin, @PesFunSenha, @PesFunSalario, @CidCodigo, convert(int, 0), '')", GxErrorMask.GX_NOMASK,prmT000710)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000711", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000711,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000712", "UPDATE [PESSOA] SET [PesTipo]=@PesTipo, [PesNome]=@PesNome, [PesCPF]=@PesCPF, [PesDatNascimento]=@PesDatNascimento, [PesEndereco]=@PesEndereco, [PesEndNumero]=@PesEndNumero, [PesBairro]=@PesBairro, [PesEmail]=@PesEmail, [PesTelefone]=@PesTelefone, [PesCelular]=@PesCelular, [PesSituacao]=@PesSituacao, [PesFunCargo]=@PesFunCargo, [PesFunDatAdmissao]=@PesFunDatAdmissao, [PesFunDatDemissao]=@PesFunDatDemissao, [PesFunLogin]=@PesFunLogin, [PesFunSenha]=@PesFunSenha, [PesFunSalario]=@PesFunSalario, [CidCodigo]=@CidCodigo  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000712)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000713", "DELETE FROM [PESSOA]  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000713)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000714", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000714,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000715", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000715,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000716", "SELECT TOP 1 [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocVenPesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000716,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000717", "SELECT TOP 1 [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCliPesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000717,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000718", "SELECT TOP 1 [PesCodigo], [PesDepCodigo] FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesDepCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000718,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000719", "SELECT TOP 1 [PesCodigo], [PesDepCodigo] FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000719,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000720", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000720,100,0,true,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((short[]) buf[21])[0] = rslt.getShort(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((short[]) buf[23])[0] = rslt.getShort(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((decimal[]) buf[33])[0] = rslt.getDecimal(18) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(18);
                ((int[]) buf[35])[0] = rslt.getInt(19) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(19);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((short[]) buf[21])[0] = rslt.getShort(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((short[]) buf[23])[0] = rslt.getShort(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDate(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((DateTime[]) buf[27])[0] = rslt.getGXDate(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((decimal[]) buf[33])[0] = rslt.getDecimal(18) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(18);
                ((int[]) buf[35])[0] = rslt.getInt(19) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(19);
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getString(6, 2) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((short[]) buf[27])[0] = rslt.getShort(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((short[]) buf[29])[0] = rslt.getShort(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((DateTime[]) buf[33])[0] = rslt.getGXDate(18) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(18);
                ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(19);
                ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
                ((bool[]) buf[38])[0] = rslt.wasNull(20);
                ((decimal[]) buf[39])[0] = rslt.getDecimal(21) ;
                ((bool[]) buf[40])[0] = rslt.wasNull(21);
                ((int[]) buf[41])[0] = rslt.getInt(22) ;
                ((bool[]) buf[42])[0] = rslt.wasNull(22);
                ((int[]) buf[43])[0] = rslt.getInt(23) ;
                ((bool[]) buf[44])[0] = rslt.wasNull(23);
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 18 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(11, (short)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(12, (short)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(14, (DateTime)parms[27]);
                }
                if ( (bool)parms[28] )
                {
                   stmt.setNull( 15 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(15, (String)parms[29]);
                }
                if ( (bool)parms[30] )
                {
                   stmt.setNull( 16 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(16, (String)parms[31]);
                }
                if ( (bool)parms[32] )
                {
                   stmt.setNull( 17 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(17, (decimal)parms[33]);
                }
                if ( (bool)parms[34] )
                {
                   stmt.setNull( 18 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(18, (int)parms[35]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(1, (short)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 8 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[15]);
                }
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[17]);
                }
                if ( (bool)parms[18] )
                {
                   stmt.setNull( 10 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(11, (short)parms[21]);
                }
                if ( (bool)parms[22] )
                {
                   stmt.setNull( 12 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(12, (short)parms[23]);
                }
                if ( (bool)parms[24] )
                {
                   stmt.setNull( 13 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(13, (DateTime)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(14, (DateTime)parms[27]);
                }
                if ( (bool)parms[28] )
                {
                   stmt.setNull( 15 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(15, (String)parms[29]);
                }
                if ( (bool)parms[30] )
                {
                   stmt.setNull( 16 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(16, (String)parms[31]);
                }
                if ( (bool)parms[32] )
                {
                   stmt.setNull( 17 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(17, (decimal)parms[33]);
                }
                if ( (bool)parms[34] )
                {
                   stmt.setNull( 18 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(18, (int)parms[35]);
                }
                stmt.SetParameter(19, (int)parms[36]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 13 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
