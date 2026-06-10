/*
               File: Cliente
        Description: Cadastro de clientes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 8:22:48.74
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
   public class tcliente : GXTransaction
   {
      public tcliente( int hnd ,
                       ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tcliente( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tcliente( IGxContext context ,
                       int hnd ,
                       ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey011( )
      {
         A38PesTipo = 0 ;
         n38PesTipo = false ;
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
         A12EstNome = "" ;
         n12EstNome = false ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
         A27CidNome = "" ;
         n27CidNome = false ;
         A17PesEnde = "" ;
         n17PesEnde = false ;
         n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
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
         A83Depende = 0 ;
         n83Depende = false ;
         A112DepVal = "" ;
         n112DepVal = false ;
      }

      protected void InitAll011( )
      {
         A48PesDepT = 0 ;
         K13PesCodi = A13PesCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A38PesTipo = i38PesTipo ;
         n38PesTipo = false ;
      }

      protected void InitializeNonKey012( )
      {
      }

      protected void InitAll012( )
      {
         A46PesDepC = 0 ;
         A47PesDepN = "" ;
         n47PesDepN = false ;
         K46PesDepC = A46PesDepC ;
         geteqAfterKey2 = 1 ;
         InitializeNonKey012( ) ;
      }

      protected void StandaloneModalInsert012( )
      {
      }

      protected void ResetCaption010( )
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
         return "Cliente" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de clientes." ;
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
         return 561 ;
      }

      public override int getFrmHeight( )
      {
         return 455 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TCliente.htm";
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
         GXPanel1 = new GXPanel(this, 3 , 25 , 561 , 455 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         bttBtn_movimentos = UIFactory.getGXButton( GXPanel1 , "Movimentos" ,  338 ,  416 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_movimentos.setTooltip("Movimentos");
         bttBtn_movimentos.addActionListener(this);
         bttBtn_movimentos.setFiresEvents(false);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Enter" ,  442 ,  416 ,  89 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Enter");
         bttBtn_enter.addActionListener(this);
         tctrlCadastrodecliente = new GXTabControl (this,  GXPanel1 , 0 , 0 , 561 , 404 , UIFactory.getColor(5) , UIFactory.getColor(8) , 0, 0, 0, false );
         tpagetpage3 = new GXTabPage ( tctrlCadastrodecliente , "Cliente" , 5 , 29 , 556 , 375 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         edtPesCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),91, 61, 117, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 91 , 61 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" );
         ((GXEdit) edtPesCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtPesCodigo.addFocusListener(this);
         edtPesCodigo.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),143, 87, 364, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 143 , 87 , 364 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A14PesNome" );
         ((GXEdit) edtPesNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesNome.addFocusListener(this);
         edtPesNome.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesDatNascimento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),169, 113, 104, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 169 , 113 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A111PesDat" );
         ((GXEdit) edtPesDatNascimento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesDatNascimento.addFocusListener(this);
         edtPesDatNascimento.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesCPF = new GUIObjectString ( new GXEdit(14, "999.999.999-99", UIFactory.getFont( "Courier New", 0, 9),325, 113, 182, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 325 , 113 , 182 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A15PesCPF" );
         ((GXEdit) edtPesCPF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesCPF.addFocusListener(this);
         edtPesCPF.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesEndereco = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),117, 139, 390, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 117 , 139 , 390 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A17PesEnde" );
         ((GXEdit) edtPesEndereco.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEndereco.addFocusListener(this);
         edtPesEndereco.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesEndNumero = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),169, 165, 91, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 169 , 165 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A18PesEndN" );
         ((GXEdit) edtPesEndNumero.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEndNumero.addFocusListener(this);
         edtPesEndNumero.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesBairro = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),325, 165, 182, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 325 , 165 , 182 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A19PesBair" );
         ((GXEdit) edtPesBairro.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesBairro.addFocusListener(this);
         edtPesBairro.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesEmail = new GUIObjectString ( new GXEdit(100, "@!", UIFactory.getFont( "Courier New", 0, 9),91, 191, 416, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 91 , 191 , 416 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A20PesEmai" );
         ((GXEdit) edtPesEmail.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEmail.addFocusListener(this);
         edtPesEmail.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesTelefone = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),169, 217, 117, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 169 , 217 , 117 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A21PesTele" );
         ((GXEdit) edtPesTelefone.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesTelefone.addFocusListener(this);
         edtPesTelefone.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtPesCelular = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),403, 217, 104, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 403 , 217 , 104 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A22PesCelu" );
         ((GXEdit) edtPesCelular.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesCelular.addFocusListener(this);
         edtPesCelular.getGXComponent().setHelpId("HLP_TCliente.htm");
         cmbPesSituacao = new GUIObjectShort ( new GXComboBox(tpagetpage3.getGXPanel()) , tpagetpage3.getGXPanel() , 104 , 243 , 75 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A23PesSitu" );
         ((GXComboBox) cmbPesSituacao.getGXComponent()).addItem( new java.lang.Short(0),"Inativo");
         ((GXComboBox) cmbPesSituacao.getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         cmbPesSituacao.addFocusListener(this);
         cmbPesSituacao.addItemListener(this);
         cmbPesSituacao.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtEstCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),312, 243, 73, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 312 , 243 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" );
         ((GXEdit) edtEstCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtEstCodigo.addFocusListener(this);
         edtEstCodigo.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtEstUF = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),429, 243, 78, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 429 , 243 , 78 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" );
         ((GXEdit) edtEstUF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstUF.addFocusListener(this);
         edtEstUF.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtEstNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),91, 269, 416, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 91 , 269 , 416 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A12EstNome" );
         ((GXEdit) edtEstNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstNome.addFocusListener(this);
         edtEstNome.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtCidCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),154, 295, 73, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 154 , 295 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A26CidCodi" );
         ((GXEdit) edtCidCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCidCodigo.addFocusListener(this);
         edtCidCodigo.getGXComponent().setHelpId("HLP_TCliente.htm");
         edtCidNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),299, 295, 208, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 299 , 295 , 208 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A27CidNome" );
         ((GXEdit) edtCidNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtCidNome.addFocusListener(this);
         edtCidNome.getGXComponent().setHelpId("HLP_TCliente.htm");
         chkDepende = new GUIObjectShort ( new GXCheckBox(tpagetpage3.getGXPanel(), "Dependente" , new java.lang.Short(1), new java.lang.Short(0)) , tpagetpage3.getGXPanel() , 39 , 338 , 91 , 16 , Integer.MAX_VALUE , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A83Depende" );
         chkDepende.addFocusListener(this);
         chkDepende.addItemListener(this);
         chkDepende.getGXComponent().setHelpId("HLP_TCliente.htm");
         lbllbl36 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Cadastro de cliente", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 111 , 13 );
         lbllbl35 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 65 , 40 , 13 );
         lbllbl31 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Nome completo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 91 , 88 , 13 );
         lbllbl29 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Data de nascimento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 117 , 114 , 13 );
         lbllbl33 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "CPF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 286 , 117 , 24 , 13 );
         lbllbl27 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Endereço", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 143 , 121 , 13 );
         lbllbl25 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Número de endereço", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 169 , 119 , 13 );
         lbllbl23 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Bairro", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 273 , 169 , 34 , 13 );
         lbllbl21 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "E-mail", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 195 , 35 , 13 );
         lbllbl19 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Telefone residencial", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 221 , 116 , 13 );
         lbllbl17 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Telefone celular", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 299 , 221 , 93 , 13 );
         lbllbl15 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 247 , 51 , 13 );
         lbllbl13 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código do Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 195 , 247 , 101 , 13 );
         lbllbl11 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 403 , 247 , 17 , 13 );
         lbllbl9 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 273 , 40 , 13 );
         lbllbl7 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código da cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 299 , 100 , 13 );
         lbllbl6 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 247 , 299 , 40 , 13 );
         tpagetpage38 = new GXTabPage ( tctrlCadastrodecliente , "Dependente" , 5 , 29 , 556 , 375 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         addSubfile ( subDepgrid  = new GXSubfileTRN ( new Cliente_flow39(this) , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 77, 19, tpagetpage38.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 76 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A46PesDepC" ), "Código"  , UIFactory.getColor(8) , UIFactory.getColor(15) , 76 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 296, 19, tpagetpage38.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 295 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A47PesDepN" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 295 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 14 , 18 , tpagetpage38.getGXPanel() , 65 , 65 , 429 , 286 ,  18 ));
         subDepgrid.addActionListener(this);
         subDepgrid.addFocusListener(this);
         subDepgrid.setSortOnClick(false);
         lbllbl42 = UIFactory.getLabel(tpagetpage38.getGXPanel(), "Vinculação de dependente", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 153 , 13 );
         subDepgrid.getColumn(0).addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         edtCidCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtPesCodigo ,
                   edtPesNome ,
                   edtPesDatNascimento ,
                   edtPesCPF ,
                   edtPesEndereco ,
                   edtPesEndNumero ,
                   edtPesBairro ,
                   edtPesEmail ,
                   edtPesTelefone ,
                   edtPesCelular ,
                   cmbPesSituacao ,
                   edtEstCodigo ,
                   edtEstUF ,
                   edtEstNome ,
                   edtCidCodigo ,
                   edtCidNome ,
                   chkDepende ,
                   subDepgrid ,
                   bttBtn_enter ,
                   bttBtn_movimentos
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Pescodigo();
         setFocus(edtPesNome, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey011( ) ;
         subDepgrid.startLoad();
         subtcliente39 = new subtcliente39 ();
         subDepgrid.endLoad();
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setGXEnabled(0);
            edtCidCodigo.setEnabled(0);
            edtCidNome.setEnabled(0);
            edtEstNome.setEnabled(0);
            edtEstUF.setEnabled(0);
            edtEstCodigo.setEnabled(0);
            cmbPesSituacao.setEnabled(0);
            edtPesCelular.setEnabled(0);
            edtPesTelefone.setEnabled(0);
            edtPesEmail.setEnabled(0);
            edtPesBairro.setEnabled(0);
            edtPesEndNumero.setEnabled(0);
            edtPesEndereco.setEnabled(0);
            edtPesDatNascimento.setEnabled(0);
            edtPesNome.setEnabled(0);
            edtPesCPF.setEnabled(0);
            edtPesCodigo.setEnabled(0);
            chkDepende.setEnabled(0);
            subDepgrid.getColumn(0).setEnabled(0);
            subDepgrid.getColumn(1).setEnabled(0);
            setFocus(bttBtn_enter, true);
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
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttBtn_enter.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captiondelete"));
         }
         else
         {
         }
      }

      protected void AfterTrn( )
      {
         if ( ( trnEnded == 1 ) )
         {
            /* Execute user event: E11012 */
            E11012 ();
            trnEnded = 0 ;
            if (!cleanedUp) {
               standaloneNotModal( ) ;
               standaloneModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  )
               {
                  /* Clear variables for new insertion. */
                  InitAll011( ) ;
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

      public void loadToBuffer39( )
      {
         subtcliente39 oAux = subtcliente39 ;
         subtcliente39 = new subtcliente39 ();
         variablesToSubfile39 ();
         subDepgrid.addElement(subtcliente39);
         subtcliente39 = oAux;
      }

      public bool isLoadAtStartup_flow39( )
      {
         return false;
      }

      public void autoRefresh_flow39( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
      }

      public bool getSearch_flow39( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow39( )
      {
      }

      public void resetSearchConditions_flow39( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow39( )
      {
         if ( subDepgrid.getItemCount() > 0 )
         {
            subtcliente39 = ( subtcliente39 ) subDepgrid.getElementAt(subDepgrid.getItemCount() -1);
            subfileToVariables39 ();
            /* Save values for previous() function. */
         }
         subtcliente39 = new subtcliente39 ();
         InitAll012( ) ;
         sMode2 = Gx_mode ;
         Gx_mode = "INS" ;
         standaloneModal012( ) ;
         Gx_mode = sMode2 ;
         variablesToSubfile39 ();
         return subtcliente39 ;
      }

      public bool getSearch_flow39( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow39( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow39( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         String Gx_mode = element.getMode();
         subtcliente39 subtcliente39  = ( subtcliente39 ) element;
         if ( col == 0 )
         {
            return ( ( A83Depende == 1 ) || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  );
         }
         return !enabled;
      }

      public void refresh_flow39( )
      {
      }

      public class Cliente_flow39 : GXSubfileFlow
      {
         tcliente _sf ;

         public Cliente_flow39( tcliente uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow39();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow39(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow39();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow39();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow39(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow39();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow39(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow39(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow39(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow39();
         }

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
         /* Execute user event: E12012 */
         E12012 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         lastAnyError = AnyError ;
         AnyError = 0;
         if ( bttBtn_enter.isEventSource(eventSource) ) {
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
         if ( bttBtn_movimentos.isEventSource(eventSource) ) {
            if ( ( lastAnyError != 0 ) )
            {
               return;
            }
            /* Execute user event: E13012 */
            E13012 ();
            if (!cleanedUp) {
               VariablesToControls();
            }
            return;
         }
         if ( subDepgrid.isEventSource(eventSource) ) {
            GXEnter( );
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtCidCodigo.getGXCursor() );
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            setGXCursor( edtCidNome.getGXCursor() );
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            setGXCursor( edtEstNome.getGXCursor() );
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            setGXCursor( edtEstUF.getGXCursor() );
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtEstCodigo.getGXCursor() );
            return;
         }
         if ( cmbPesSituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbPesSituacao.getGXCursor() );
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            setGXCursor( edtPesCelular.getGXCursor() );
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            setGXCursor( edtPesTelefone.getGXCursor() );
            return;
         }
         if ( edtPesEmail.isEventSource(eventSource) ) {
            setGXCursor( edtPesEmail.getGXCursor() );
            return;
         }
         if ( edtPesBairro.isEventSource(eventSource) ) {
            setGXCursor( edtPesBairro.getGXCursor() );
            return;
         }
         if ( edtPesEndNumero.isEventSource(eventSource) ) {
            setGXCursor( edtPesEndNumero.getGXCursor() );
            return;
         }
         if ( edtPesEndereco.isEventSource(eventSource) ) {
            setGXCursor( edtPesEndereco.getGXCursor() );
            return;
         }
         if ( edtPesDatNascimento.isEventSource(eventSource) ) {
            setGXCursor( edtPesDatNascimento.getGXCursor() );
            return;
         }
         if ( edtPesNome.isEventSource(eventSource) ) {
            setGXCursor( edtPesNome.getGXCursor() );
            return;
         }
         if ( edtPesCPF.isEventSource(eventSource) ) {
            setGXCursor( edtPesCPF.getGXCursor() );
            return;
         }
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtPesCodigo.getGXCursor() );
            return;
         }
         if ( chkDepende.isEventSource(eventSource) ) {
            setGXCursor( chkDepende.getGXCursor() );
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
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            Valid_Pescodigo ();
            return;
         }
         if ( edtPesNome.isEventSource(eventSource) ) {
            Valid_Pesnome ();
            return;
         }
         if ( edtPesCPF.isEventSource(eventSource) ) {
            Valid_Pescpf ();
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
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            Valid_Pestelefone ();
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            Valid_Pescelular ();
            return;
         }
         if ( chkDepende.isEventSource(eventSource) ) {
            Valid_Depende ();
            return;
         }
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            Valid_Cidcodigo ();
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            Valid_Estcodigo ();
            return;
         }
         if ( subDepgrid.getColumn(0).isEventSource(eventSource) ) {
            subtcliente39 = (subtcliente39)subDepgrid.cloneCurrentElement();
            if ( ( subtcliente39.isDeleted() != 1 ) )
            {
               subfileToVariables39 ();
               sMode2 = Gx_mode ;
               Gx_mode = (String)(subtcliente39.getTrnMode()) ;
               Valid_Pesdepcodigo ();
               Gx_mode = sMode2 ;
            }
            return;
         }
         if ( subDepgrid.getColumn(1).isEventSource(eventSource) ) {
            subtcliente39 = (subtcliente39)subDepgrid.cloneCurrentElement();
            if ( ( subtcliente39.isDeleted() != 1 ) )
            {
               subfileToVariables39 ();
               sMode2 = Gx_mode ;
               Gx_mode = (String)(subtcliente39.getTrnMode()) ;
               Valid_Pesdepnome ();
               Gx_mode = sMode2 ;
            }
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtCidCodigo.isEventSource(eventSource) ) {
            A26CidCodi = edtCidCodigo.getValue() ;
            n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
            return;
         }
         if ( edtCidNome.isEventSource(eventSource) ) {
            A27CidNome = edtCidNome.getValue() ;
            return;
         }
         if ( edtEstNome.isEventSource(eventSource) ) {
            A12EstNome = edtEstNome.getValue() ;
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            A25EstUF = edtEstUF.getValue() ;
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            A24EstCodi = edtEstCodigo.getValue() ;
            return;
         }
         if ( cmbPesSituacao.isEventSource(eventSource) ) {
            A23PesSitu = cmbPesSituacao.getValue() ;
            n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            A22PesCelu = edtPesCelular.getValue() ;
            n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            A21PesTele = edtPesTelefone.getValue() ;
            n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesEmail.isEventSource(eventSource) ) {
            A20PesEmai = edtPesEmail.getValue() ;
            n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesBairro.isEventSource(eventSource) ) {
            A19PesBair = edtPesBairro.getValue() ;
            n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesEndNumero.isEventSource(eventSource) ) {
            A18PesEndN = edtPesEndNumero.getValue() ;
            n18PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesEndereco.isEventSource(eventSource) ) {
            A17PesEnde = edtPesEndereco.getValue() ;
            n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesDatNascimento.isEventSource(eventSource) ) {
            A111PesDat = edtPesDatNascimento.getValue() ;
            n111PesDat = (((DateTime.MinValue==A111PesDat)) ? true : false) ;
            return;
         }
         if ( edtPesNome.isEventSource(eventSource) ) {
            A14PesNome = edtPesNome.getValue() ;
            n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesCPF.isEventSource(eventSource) ) {
            A15PesCPF = edtPesCPF.getValue() ;
            n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            A13PesCodi = edtPesCodigo.getValue() ;
            return;
         }
         if ( chkDepende.isEventSource(eventSource) ) {
            A83Depende = chkDepende.getValue() ;
            n83Depende = (((0==A83Depende)) ? true : false) ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
         if ( chkDepende.isEventSource(eventSource) ) {
            /* Execute user event: E14012 */
            E14012 ();
            return;
         }
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E15012 */
            E15012 ();
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
         if ( ( edtCidCodigo.isEventSource(eventSource) ) && ( ( A26CidCodi != edtCidCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtCidNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A27CidNome.TrimEnd(' '), edtCidNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtEstNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A12EstNome.TrimEnd(' '), edtEstNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtEstUF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A25EstUF.TrimEnd(' '), edtEstUF.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtEstCodigo.isEventSource(eventSource) ) && ( ( A24EstCodi != edtEstCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( cmbPesSituacao.isEventSource(eventSource) ) && ( ( A23PesSitu != cmbPesSituacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesCelular.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A22PesCelu.TrimEnd(' '), edtPesCelular.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesTelefone.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A21PesTele.TrimEnd(' '), edtPesTelefone.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesEmail.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A20PesEmai.TrimEnd(' '), edtPesEmail.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesBairro.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A19PesBair.TrimEnd(' '), edtPesBairro.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesEndNumero.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A18PesEndN.TrimEnd(' '), edtPesEndNumero.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesEndereco.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A17PesEnde.TrimEnd(' '), edtPesEndereco.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesDatNascimento.isEventSource(eventSource) ) && ( ( A111PesDat != edtPesDatNascimento.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtPesNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A14PesNome.TrimEnd(' '), edtPesNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesCPF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A15PesCPF.TrimEnd(' '), edtPesCPF.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( chkDepende.isEventSource(eventSource) ) && ( ( A83Depende != chkDepende.getValue() ) ) )
         {
            return true;
         }
         if (subDepgrid.elementsEventSource(eventSource))
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
         ResetCaption010( ) ;
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
         return bttBtn_enter ;
      }

      public bool promptHandler( Object eventSource )
      {
         if (( subDepgrid.getColumn(0).isEventSource(eventSource) ) && ( subDepgrid.getColumn(0).isEnabled() )) {
            eventLevelContext( );
            prompt_46_2( ) ;
            eventLevelResetContext( );
            return true ;
         }
         if (( edtCidCodigo.isEventSource(eventSource) ) && ( edtCidCodigo.isEnabled() )) {
            prompt_26_1( ) ;
            return true ;
         }
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
         if ( subDepgrid .isEventSource(eventSource)) {
            if ( row < 0 ) {
               subtcliente39 = ( subtcliente39 ) subDepgrid.getCurrentElement() ;
            }
            else
            {
               subtcliente39 = ( subtcliente39 ) subDepgrid.getElementAt(row) ;
            }
            subfileToVariables39 ();
            if ( ( subtcliente39.isDeleted() == 1 ) )
            {
               sMode2 = Gx_mode ;
               Gx_mode = "DLT" ;
            }
            else
            {
               sMode2 = Gx_mode ;
               Gx_mode = "INS" ;
            }
            validate_on_delete2 ();
            O48PesDepT = A48PesDepT ;
            Gx_mode = sMode2 ;
         }
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( edtCidCodigo.isEventSource(eventSource) )
         {
            edtCidCodigo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( cmbPesSituacao.isEventSource(eventSource) )
         {
            cmbPesSituacao.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesCelular.isEventSource(eventSource) )
         {
            edtPesCelular.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesTelefone.isEventSource(eventSource) )
         {
            edtPesTelefone.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesEmail.isEventSource(eventSource) )
         {
            edtPesEmail.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesBairro.isEventSource(eventSource) )
         {
            edtPesBairro.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesEndNumero.isEventSource(eventSource) )
         {
            edtPesEndNumero.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesEndereco.isEventSource(eventSource) )
         {
            edtPesEndereco.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesDatNascimento.isEventSource(eventSource) )
         {
            edtPesDatNascimento.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesNome.isEventSource(eventSource) )
         {
            edtPesNome.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( edtPesCPF.isEventSource(eventSource) )
         {
            edtPesCPF.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
         if ( chkDepende.isEventSource(eventSource) )
         {
            chkDepende.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      protected void variablesToSubfile39( )
      {
         subtcliente39.setPesDepCodigo(A46PesDepC);
         subtcliente39.setPesDepNome(A47PesDepN);
      }

      protected void subfileToVariables39( )
      {
         A46PesDepC = subtcliente39.getPesDepCodigo();
         A47PesDepN = subtcliente39.getPesDepNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtCidCodigo.setValue( A26CidCodi );
         edtCidNome.setValue( A27CidNome );
         edtEstNome.setValue( A12EstNome );
         edtEstUF.setValue( A25EstUF );
         edtEstCodigo.setValue( A24EstCodi );
         cmbPesSituacao.setValue( A23PesSitu );
         edtPesCelular.setValue( A22PesCelu );
         edtPesTelefone.setValue( A21PesTele );
         edtPesEmail.setValue( A20PesEmai );
         edtPesBairro.setValue( A19PesBair );
         edtPesEndNumero.setValue( A18PesEndN );
         edtPesEndereco.setValue( A17PesEnde );
         edtPesDatNascimento.setValue( A111PesDat );
         edtPesNome.setValue( A14PesNome );
         edtPesCPF.setValue( A15PesCPF );
         edtPesCodigo.setValue( A13PesCodi );
         chkDepende.setValue( A83Depende );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A26CidCodi = (int)(edtCidCodigo.getValue()) ;
         edtCidCodigo.setValue(A26CidCodi);
         n26CidCodi = false ;
         n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
         A27CidNome = (String)(edtCidNome.getValue()) ;
         edtCidNome.setValue(A27CidNome);
         n27CidNome = false ;
         A12EstNome = (String)(edtEstNome.getValue()) ;
         edtEstNome.setValue(A12EstNome);
         n12EstNome = false ;
         A25EstUF = (String)(edtEstUF.getValue()) ;
         edtEstUF.setValue(A25EstUF);
         n25EstUF = false ;
         A24EstCodi = (int)(edtEstCodigo.getValue()) ;
         edtEstCodigo.setValue(A24EstCodi);
         n24EstCodi = false ;
         A23PesSitu = (short)(cmbPesSituacao.getValue()) ;
         cmbPesSituacao.setValue(A23PesSitu);
         n23PesSitu = false ;
         n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
         A22PesCelu = (String)(edtPesCelular.getValue()) ;
         edtPesCelular.setValue(A22PesCelu);
         n22PesCelu = false ;
         n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
         A21PesTele = (String)(edtPesTelefone.getValue()) ;
         edtPesTelefone.setValue(A21PesTele);
         n21PesTele = false ;
         n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
         A20PesEmai = (String)(edtPesEmail.getValue()) ;
         edtPesEmail.setValue(A20PesEmai);
         n20PesEmai = false ;
         n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
         A19PesBair = (String)(edtPesBairro.getValue()) ;
         edtPesBairro.setValue(A19PesBair);
         n19PesBair = false ;
         n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
         A18PesEndN = (String)(edtPesEndNumero.getValue()) ;
         edtPesEndNumero.setValue(A18PesEndN);
         n18PesEndN = false ;
         n18PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
         A17PesEnde = (String)(edtPesEndereco.getValue()) ;
         edtPesEndereco.setValue(A17PesEnde);
         n17PesEnde = false ;
         n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
         A111PesDat = (DateTime)(edtPesDatNascimento.getValue()) ;
         edtPesDatNascimento.setValue(A111PesDat);
         n111PesDat = false ;
         n111PesDat = (((DateTime.MinValue==A111PesDat)) ? true : false) ;
         A14PesNome = (String)(edtPesNome.getValue()) ;
         edtPesNome.setValue(A14PesNome);
         n14PesNome = false ;
         n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
         A15PesCPF = (String)(edtPesCPF.getValue()) ;
         edtPesCPF.setValue(A15PesCPF);
         n15PesCPF = false ;
         n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
         A13PesCodi = (int)(edtPesCodigo.getValue()) ;
         edtPesCodigo.setValue(A13PesCodi);
         A83Depende = (short)(chkDepende.getValue()) ;
         chkDepende.setValue(A83Depende);
         n83Depende = false ;
         n83Depende = (((0==A83Depende)) ? true : false) ;
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subDepgrid.inValidElement() )
         {
            subtcliente39 = ( subtcliente39 ) subDepgrid.getCurrentElement() ;
         }
         else
         {
            subtcliente39 = new subtcliente39 ();
         }
         subfileToVariables39 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile39 ();
         subDepgrid.refreshLineValue(subtcliente39);
      }

      protected void reloadGridRow( )
      {
         if ( subDepgrid.inValidElement() )
         {
            subtcliente39 = ( subtcliente39 ) subDepgrid.getCurrentElement() ;
         }
         else
         {
            subtcliente39 = new subtcliente39 ();
         }
         subfileToVariables39 ();
      }

      protected void prompt_26_1( )
      {
         new wgx0080(context, base.remoteHandle, base.context).execute( out  A26CidCodi) ;
         edtCidCodigo.setValue( A26CidCodi );
         n26CidCodi = false ;
         setFocus(edtCidCodigo);
         ResetCaption010( ) ;
      }

      protected void prompt_46_2( )
      {
         new wgx0010(context, base.remoteHandle, base.context).execute( out  A46PesDepC) ;
         ((subtcliente39)subDepgrid.getCurrentElement()).setPesDepCodigo(A46PesDepC);
         subDepgrid.refreshLineValue(subDepgrid.getSelectedElement());
         subDepgrid.repaint();
         ResetCaption010( ) ;
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

      protected void Valid_Pesnome( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) )
         {
            GXutil.msg( me(), "Nome deve ser informado!" );
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
         if ( true /* After */ && ((DateTime.MinValue==A111PesDat)) )
         {
            GXutil.msg( me(), "Data de nascimento deve ser informada!" );
            AnyError = 1 ;
            setNextFocus( edtPesDatNascimento );
            setFocusNext();
         }
      }

      protected void Valid_Pescpf( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) && ( A83Depende != 0 ) )
         {
            GXutil.msg( me(), "CPF deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesCPF );
            setFocusNext();
         }
      }

      protected void Valid_Pesendereco( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) && ( A83Depende != 0 ) )
         {
            GXutil.msg( me(), "Endereço deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesEndereco );
            setFocusNext();
         }
      }

      protected void Valid_Pesbairro( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) && ( A83Depende != 0 ) )
         {
            GXutil.msg( me(), "Bairro deve ser informado!" );
            AnyError = 1 ;
            setNextFocus( edtPesBairro );
            setFocusNext();
         }
      }

      protected void Valid_Pestelefone( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            GXutil.msg( me(), "Telefone residencial não informado!" );
         }
      }

      protected void Valid_Pescelular( )
      {
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            GXutil.msg( me(), "Telefone celular não informado!" );
         }
      }

      protected void Valid_Estcodigo( )
      {
         /* Using cursor T00012 */
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
         A25EstUF = T00012_A25EstUF[0] ;
         n25EstUF = T00012_n25EstUF[0] ;
         A12EstNome = T00012_A12EstNome[0] ;
         n12EstNome = T00012_n12EstNome[0] ;
         pr_default.close(0);
         edtEstUF.setValue( A25EstUF );
         edtEstNome.setValue( A12EstNome );
         pr_default.close(0);
      }

      protected void Valid_Cidcodigo( )
      {
         /* Using cursor T00013 */
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
         A27CidNome = T00013_A27CidNome[0] ;
         n27CidNome = T00013_n27CidNome[0] ;
         A24EstCodi = T00013_A24EstCodi[0] ;
         n24EstCodi = T00013_n24EstCodi[0] ;
         pr_default.close(1);
         edtCidNome.setValue( A27CidNome );
         edtEstCodigo.setValue( A24EstCodi );
         pr_default.close(1);
      }

      protected void Valid_Depende( )
      {
         reloadGridRow();
      }

      protected void Valid_Pesdepcodigo( )
      {
         if ( ( A46PesDepC != K46PesDepC ) || ( geteqAfterKey2 == 1 ) )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A46PesDepC});
            if ( (pr_default.getStatus(2) == 101) )
            {
               GXutil.msg( me(), "Não existe 'Dependente de pessoa.'." );
               AnyError = 1 ;
               subDepgrid.cancelSubfileMove();
            }
            A47PesDepN = T00014_A47PesDepN[0] ;
            n47PesDepN = T00014_n47PesDepN[0] ;
            pr_default.close(2);
            chkDepende.setValue( A83Depende );
            ((subtcliente39)subDepgrid.getCurrentElement()).setPesDepNome(A47PesDepN);
            subDepgrid.refreshLineValue(subDepgrid.getSelectedElement());
            subDepgrid.repaint();
            pr_default.close(2);
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey2 = 0 ;
            }
            else
            {
               geteqAfterKey2 = 1 ;
            }
         }
      }

      protected void Valid_Pesdepnome( )
      {
         reloadGridRow();
         O48PesDepT = A48PesDepT ;
      }

      protected void validate_on_delete2( )
      {
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A46PesDepC});
            A47PesDepN = T00014_A47PesDepN[0] ;
            n47PesDepN = T00014_n47PesDepN[0] ;
            pr_default.close(2);
         }
      }

      protected void E12012( )
      {
         eventNoLevelContext();
         /* Start Routine */
         tctrlCadastrodecliente.setActivePage(1);
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            if ( ( A83Depende == 1 ) )
            {
               bttBtn_movimentos.setGXVisible(0);
            }
         }
         else
         {
            bttBtn_movimentos.setGXVisible(0);
         }
      }

      protected void E15012( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A46PesDepC") && ( A83Depende == 0 ) )
         {
            AV12TratEr = "Inativo" ;
            new wconscliente(context, base.remoteHandle, base.context).execute( ref  AV12TratEr, out  A46PesDepC) ;
            ((subtcliente39)subDepgrid.getCurrentElement()).setPesDepCodigo(A46PesDepC);
            subDepgrid.refreshLineValue(subDepgrid.getSelectedElement());
            subDepgrid.repaint();
            if ( ( String.CompareOrdinal(AV12TratEr.TrimEnd(' '), "Ativo".TrimEnd(' ') ) == 0 ) )
            {
               GXutil.msg( me(), "O cliente não pôde ser adicionado por não estar configurado como um dependente." );
            }
         }
         else if ( GXCursor("A26CidCodi") )
         {
            new wconscidade(context, base.remoteHandle, base.context).execute( out  A26CidCodi) ;
            edtCidCodigo.setValue( A26CidCodi );
            n26CidCodi = false ;
         }
         eventLevelResetContext();
      }

      protected void E11012( )
      {
         /* After Trn Routine */
         if ( ( A83Depende == 1 ) )
         {
            new pdeldependente(context, base.remoteHandle, base.context).execute( ref  A46PesDepC) ;
            ((subtcliente39)subDepgrid.getCurrentElement()).setPesDepCodigo(A46PesDepC);
            subDepgrid.refreshLineValue(subDepgrid.getSelectedElement());
            subDepgrid.repaint();
         }
      }

      protected void E14012( )
      {
         eventLevelContext();
         /* Depende_Click Routine */
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            if ( ( A83Depende != 0 ) )
            {
               bttBtn_movimentos.setGXVisible(0);
            }
            else
            {
               bttBtn_movimentos.setGXVisible(1);
            }
         }
         else
         {
            bttBtn_movimentos.setGXVisible(0);
         }
         eventLevelResetContext();
      }

      protected void E13012( )
      {
         eventLevelContext();
         /* 'Movimentos' Routine */
         new wmovdocliente(context, base.remoteHandle, base.context).execute(  A13PesCodi) ;
         eventLevelResetContext();
      }

      /* Server side code */
      /* Aggregate/select formulas */
      protected int GetPesDepTotal0( int E13PesCodi )
      {
         Gx_cnt = 0 ;
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {E13PesCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            Gx_cnt = T00015_Gx_cnt[0] ;
         }
         pr_default.close(3);
         return Gx_cnt ;
      }

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
         PreviousCaption = bttBtn_enter.getCaption() ;
      }

      protected void ZM011( int GX_JID )
      {
         if ( ( GX_JID == 14 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z38PesTipo = T00019_A38PesTipo[0] ;
               Z14PesNome = T00019_A14PesNome[0] ;
               Z15PesCPF = T00019_A15PesCPF[0] ;
               Z111PesDat = T00019_A111PesDat[0] ;
               Z17PesEnde = T00019_A17PesEnde[0] ;
               Z18PesEndN = T00019_A18PesEndN[0] ;
               Z19PesBair = T00019_A19PesBair[0] ;
               Z20PesEmai = T00019_A20PesEmai[0] ;
               Z21PesTele = T00019_A21PesTele[0] ;
               Z22PesCelu = T00019_A22PesCelu[0] ;
               Z23PesSitu = T00019_A23PesSitu[0] ;
               Z83Depende = T00019_A83Depende[0] ;
               Z112DepVal = T00019_A112DepVal[0] ;
               Z26CidCodi = T00019_A26CidCodi[0] ;
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
               Z83Depende = A83Depende ;
               Z112DepVal = A112DepVal ;
               Z26CidCodi = A26CidCodi ;
            }
         }
         if ( ( GX_JID == -14 ) )
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
            Z83Depende = A83Depende ;
            Z112DepVal = A112DepVal ;
            Z26CidCodi = A26CidCodi ;
         }
      }

      public override void standaloneNotModal( )
      {
         A48PesDepT = GetPesDepTotal0( A13PesCodi) ;
      }

      public override void standaloneModal( )
      {
         A38PesTipo = 1 ;
         n38PesTipo = false ;
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subDepgrid.setEnabled(0);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound1 = 1 ;
            A38PesTipo = T000110_A38PesTipo[0] ;
            n38PesTipo = T000110_n38PesTipo[0] ;
            A14PesNome = T000110_A14PesNome[0] ;
            n14PesNome = T000110_n14PesNome[0] ;
            A15PesCPF = T000110_A15PesCPF[0] ;
            n15PesCPF = T000110_n15PesCPF[0] ;
            A111PesDat = T000110_A111PesDat[0] ;
            n111PesDat = T000110_n111PesDat[0] ;
            A25EstUF = T000110_A25EstUF[0] ;
            n25EstUF = T000110_n25EstUF[0] ;
            A12EstNome = T000110_A12EstNome[0] ;
            n12EstNome = T000110_n12EstNome[0] ;
            A27CidNome = T000110_A27CidNome[0] ;
            n27CidNome = T000110_n27CidNome[0] ;
            A17PesEnde = T000110_A17PesEnde[0] ;
            n17PesEnde = T000110_n17PesEnde[0] ;
            A18PesEndN = T000110_A18PesEndN[0] ;
            n18PesEndN = T000110_n18PesEndN[0] ;
            A19PesBair = T000110_A19PesBair[0] ;
            n19PesBair = T000110_n19PesBair[0] ;
            A20PesEmai = T000110_A20PesEmai[0] ;
            n20PesEmai = T000110_n20PesEmai[0] ;
            A21PesTele = T000110_A21PesTele[0] ;
            n21PesTele = T000110_n21PesTele[0] ;
            A22PesCelu = T000110_A22PesCelu[0] ;
            n22PesCelu = T000110_n22PesCelu[0] ;
            A23PesSitu = T000110_A23PesSitu[0] ;
            n23PesSitu = T000110_n23PesSitu[0] ;
            A83Depende = T000110_A83Depende[0] ;
            n83Depende = T000110_n83Depende[0] ;
            A112DepVal = T000110_A112DepVal[0] ;
            n112DepVal = T000110_n112DepVal[0] ;
            A26CidCodi = T000110_A26CidCodi[0] ;
            n26CidCodi = T000110_n26CidCodi[0] ;
            A24EstCodi = T000110_A24EstCodi[0] ;
            n24EstCodi = T000110_n24EstCodi[0] ;
            ZM011( -14) ;
         }
         pr_default.close(8);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) )
         {
            pushError( "Nome deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ! ( ((DateTime.MinValue==A111PesDat)) || ( A111PesDat >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de nascimento da pessoa fora da faixa" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((DateTime.MinValue==A111PesDat)) )
         {
            pushError( "Data de nascimento deve ser informada!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) && ( A83Depende != 0 ) )
         {
            pushError( "CPF deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) && ( A83Depende != 0 ) )
         {
            pushError( "Endereço deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) && ( A83Depende != 0 ) )
         {
            pushError( "Bairro deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            GXutil.msg( me(), "Telefone residencial não informado!" );
         }
         if ( true /* After */ && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) && ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            GXutil.msg( me(), "Telefone celular não informado!" );
         }
         /* Using cursor T00013 */
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
         A27CidNome = T00013_A27CidNome[0] ;
         n27CidNome = T00013_n27CidNome[0] ;
         A24EstCodi = T00013_A24EstCodi[0] ;
         n24EstCodi = T00013_n24EstCodi[0] ;
         pr_default.close(1);
         /* Using cursor T00012 */
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
         A25EstUF = T00012_A25EstUF[0] ;
         n25EstUF = T00012_n25EstUF[0] ;
         A12EstNome = T00012_A12EstNome[0] ;
         n12EstNome = T00012_n12EstNome[0] ;
         pr_default.close(0);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(1);
         pr_default.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor T000111 */
         pr_default.execute(9, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound1 = 1 ;
         }
         else
         {
            RcdFound1 = 0 ;
         }
         pr_default.close(9);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(7) != 101) && ( T00019_A13PesCodi[0] == A13PesCodi ) )
         {
            ZM011( 14) ;
            RcdFound1 = 1 ;
            A38PesTipo = T00019_A38PesTipo[0] ;
            n38PesTipo = T00019_n38PesTipo[0] ;
            A14PesNome = T00019_A14PesNome[0] ;
            n14PesNome = T00019_n14PesNome[0] ;
            A15PesCPF = T00019_A15PesCPF[0] ;
            n15PesCPF = T00019_n15PesCPF[0] ;
            A111PesDat = T00019_A111PesDat[0] ;
            n111PesDat = T00019_n111PesDat[0] ;
            A17PesEnde = T00019_A17PesEnde[0] ;
            n17PesEnde = T00019_n17PesEnde[0] ;
            A18PesEndN = T00019_A18PesEndN[0] ;
            n18PesEndN = T00019_n18PesEndN[0] ;
            A19PesBair = T00019_A19PesBair[0] ;
            n19PesBair = T00019_n19PesBair[0] ;
            A20PesEmai = T00019_A20PesEmai[0] ;
            n20PesEmai = T00019_n20PesEmai[0] ;
            A21PesTele = T00019_A21PesTele[0] ;
            n21PesTele = T00019_n21PesTele[0] ;
            A22PesCelu = T00019_A22PesCelu[0] ;
            n22PesCelu = T00019_n22PesCelu[0] ;
            A23PesSitu = T00019_A23PesSitu[0] ;
            n23PesSitu = T00019_n23PesSitu[0] ;
            A83Depende = T00019_A83Depende[0] ;
            n83Depende = T00019_n83Depende[0] ;
            A112DepVal = T00019_A112DepVal[0] ;
            n112DepVal = T00019_n112DepVal[0] ;
            A26CidCodi = T00019_A26CidCodi[0] ;
            n26CidCodi = T00019_n26CidCodi[0] ;
            Z13PesCodi = A13PesCodi ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load011( ) ;
            Gx_mode = sMode1 ;
         }
         else
         {
            RcdFound1 = 0 ;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode1 ;
         }
         K13PesCodi = A13PesCodi ;
         pr_default.close(7);
         subDepgrid.startLoad();
         subtcliente39 = new subtcliente39 ();
         if ( ( RcdFound1 == 1 ) )
         {
            ScanStart012( ) ;
            while ( ( RcdFound2 != 0 ) )
            {
               getByPrimaryKey012( ) ;
               O48PesDepT = A48PesDepT ;
               AddRow012( ) ;
               ScanNext012( ) ;
            }
            ScanEnd012( ) ;
         }
         subDepgrid.endLoad(new subtcliente39());
      }

      public override void getEqualNoModal( )
      {
         GetKey011( ) ;
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
         /* Using cursor T000112 */
         pr_default.execute(10, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( T000112_A13PesCodi[0] == A13PesCodi ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( T000112_A13PesCodi[0] == A13PesCodi ) )
            {
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(10);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T000113 */
         pr_default.execute(11, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( T000113_A13PesCodi[0] == A13PesCodi ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( T000113_A13PesCodi[0] == A13PesCodi ) )
            {
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(11);
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
         GetKey011( ) ;
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
               A48PesDepT = O48PesDepT ;
               Update011( ) ;
               setNextFocus( edtPesCodigo );
            }
         }
         else
         {
            if ( ( A13PesCodi != Z13PesCodi ) )
            {
               /* Insert record */
               A48PesDepT = O48PesDepT ;
               Insert011( ) ;
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
                  A48PesDepT = O48PesDepT ;
                  Insert011( ) ;
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
            A48PesDepT = O48PesDepT ;
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

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00018 */
            pr_default.execute(6, new Object[] {A13PesCodi});
            if ( ! (pr_default.getStatus(6) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"PESSOA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( Z38PesTipo != T00018_A38PesTipo[0] ) || ( String.CompareOrdinal(Z14PesNome.TrimEnd(' '), T00018_A14PesNome[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z15PesCPF.TrimEnd(' '), T00018_A15PesCPF[0].TrimEnd(' ') ) != 0 ) || ( Z111PesDat != T00018_A111PesDat[0] ) || ( String.CompareOrdinal(Z17PesEnde.TrimEnd(' '), T00018_A17PesEnde[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( String.CompareOrdinal(Z18PesEndN.TrimEnd(' '), T00018_A18PesEndN[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z19PesBair.TrimEnd(' '), T00018_A19PesBair[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z20PesEmai.TrimEnd(' '), T00018_A20PesEmai[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z21PesTele.TrimEnd(' '), T00018_A21PesTele[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z22PesCelu.TrimEnd(' '), T00018_A22PesCelu[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z23PesSitu != T00018_A23PesSitu[0] ) || ( Z83Depende != T00018_A83Depende[0] ) || ( String.CompareOrdinal(Z112DepVal.TrimEnd(' '), T00018_A112DepVal[0].TrimEnd(' ') ) != 0 ) || ( Z26CidCodi != T00018_A26CidCodi[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"PESSOA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert011( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000114 */
                     pr_default.execute(12, new Object[] {n38PesTipo, A38PesTipo, n14PesNome, A14PesNome, n15PesCPF, A15PesCPF, n111PesDat, A111PesDat, n17PesEnde, A17PesEnde, n18PesEndN, A18PesEndN, n19PesBair, A19PesBair, n20PesEmai, A20PesEmai, n21PesTele, A21PesTele, n22PesCelu, A22PesCelu, n23PesSitu, A23PesSitu, n83Depende, A83Depende, n112DepVal, A112DepVal, n26CidCodi, A26CidCodi});
                     pr_default.close(12);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000115 */
                     pr_default.execute(13);
                     A13PesCodi = T000115_A13PesCodi[0] ;
                     pr_default.close(13);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           ProcessLevel011( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              loopOnce = true;
                           }
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate011( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000116 */
                     pr_default.execute(14, new Object[] {n38PesTipo, A38PesTipo, n14PesNome, A14PesNome, n15PesCPF, A15PesCPF, n111PesDat, A111PesDat, n17PesEnde, A17PesEnde, n18PesEndN, A18PesEndN, n19PesBair, A19PesBair, n20PesEmai, A20PesEmai, n21PesTele, A21PesTele, n22PesCelu, A22PesCelu, n23PesSitu, A23PesSitu, n83Depende, A83Depende, n112DepVal, A112DepVal, n26CidCodi, A26CidCodi, A13PesCodi});
                     pr_default.close(14);
                     DeferredUpdate011( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           ProcessLevel011( ) ;
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
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      public override void delete( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls011( ) ;
            A48PesDepT = O48PesDepT ;
            ScanStart012( ) ;
            while ( ( RcdFound2 != 0 ) )
            {
               getByPrimaryKey012( ) ;
               Delete012( ) ;
               ScanNext012( ) ;
               O48PesDepT = A48PesDepT ;
            }
            ScanEnd012( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeDelete011( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000117 */
                     pr_default.execute(15, new Object[] {A13PesCodi});
                     pr_default.close(15);
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
         }
         sMode1 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel011( ) ;
         Gx_mode = sMode1 ;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000118 */
            pr_default.execute(16, new Object[] {n26CidCodi, A26CidCodi});
            A27CidNome = T000118_A27CidNome[0] ;
            n27CidNome = T000118_n27CidNome[0] ;
            A24EstCodi = T000118_A24EstCodi[0] ;
            n24EstCodi = T000118_n24EstCodi[0] ;
            pr_default.close(16);
            /* Using cursor T000119 */
            pr_default.execute(17, new Object[] {n24EstCodi, A24EstCodi});
            A25EstUF = T000119_A25EstUF[0] ;
            n25EstUF = T000119_n25EstUF[0] ;
            A12EstNome = T000119_A12EstNome[0] ;
            n12EstNome = T000119_n12EstNome[0] ;
            pr_default.close(17);
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000120 */
            pr_default.execute(18, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(18) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de locações."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(18);
            /* Using cursor T000121 */
            pr_default.execute(19, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(19) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de locações."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(19);
            /* Using cursor T000122 */
            pr_default.execute(20, new Object[] {A13PesCodi});
            if ( (pr_default.getStatus(20) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Dependente"}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(20);
         }
      }

      protected void ProcessNestedLevel012( )
      {
         s48PesDepT = O48PesDepT ;
         nGXsfl_39_idx = 0 ;
         while ( ( nGXsfl_39_idx < subDepgrid.getItemCount() ) )
         {
            ReadRow012( ) ;
            if ( ( subtcliente39.isLoaded() != 0 ) || ( subtcliente39.isChanged() != 0 ) )
            {
               standaloneNotModal012( ) ;
               GetKey012( ) ;
               if ( ( subtcliente39.isLoaded() == 0 ) && ( subtcliente39.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound2 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     Insert012( ) ;
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtPesCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound2 != 0 ) )
                  {
                     if ( ( subtcliente39.isDeleted() != 0 ) && ( subtcliente39.isLoaded() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        Delete012( ) ;
                     }
                     else
                     {
                        if ( ( subtcliente39.isChanged() != 0 ) && ( subtcliente39.isLoaded() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           Update012( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtcliente39.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtPesCodigo );
                     }
                  }
               }
               O48PesDepT = A48PesDepT ;
            }
         }
         subDepgrid.endLoad(new subtcliente39());
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ProcessLevel011( )
      {
         /* Save parent mode. */
         sMode1 = Gx_mode ;
         ProcessNestedLevel012( ) ;
         if ( ( AnyError != 0 ) )
         {
            O48PesDepT = s48PesDepT ;
         }
         /* Restore parent mode. */
         Gx_mode = sMode1 ;
         /* ' Update level parameters */
      }

      protected void EndLevel011( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(6);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete011( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(7);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(2);
            context.CommitDataStores("TCliente");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(5);
            pr_default.close(4);
            pr_default.close(16);
            pr_default.close(17);
            pr_default.close(2);
            context.RollbackDataStores("TCliente");
            nGXsfl_39_idx = 0 ;
            while ( ( nGXsfl_39_idx < subDepgrid.getItemCount() ) )
            {
               ReadRow012( ) ;
               /* Using cursor T00017 */
               pr_default.execute(5, new Object[] {A13PesCodi, A46PesDepC});
               if ( (pr_default.getStatus(5) != 101) && ( T00017_A13PesCodi[0] == A13PesCodi ) )
               {
                  if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
                  {
                  }
                  else
                  {
                  }
                  variablesToSubfile39 ();
               }
               pr_default.close(5);
            }
         }
         IsModified = 0 ;
      }

      protected void ScanStart011( )
      {
         /* Using cursor T000123 */
         pr_default.execute(21, new Object[] {A13PesCodi});
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound1 = 1 ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         pr_default.readNext(21);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound1 = 1 ;
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(21);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void ZM012( int GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
            }
            else
            {
            }
         }
         if ( ( GX_JID == -17 ) )
         {
            Z13PesCodi = A13PesCodi ;
            Z46PesDepC = A46PesDepC ;
         }
      }

      protected void standaloneNotModal012( )
      {
         A48PesDepT = GetPesDepTotal0( A13PesCodi) ;
         O48PesDepT = A48PesDepT ;
         if ( ( A83Depende == 1 ) )
         {
            subDepgrid.getColumn(0).setEnabled(0);
         }
         else
         {
            subDepgrid.getColumn(0).setEnabled(1);
         }
      }

      protected void standaloneModal012( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subDepgrid.setEnabled(0);
         }
      }

      protected void Load012( )
      {
         /* Using cursor T000124 */
         pr_default.execute(22, new Object[] {A13PesCodi, A46PesDepC});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound2 = 1 ;
            A47PesDepN = T000124_A47PesDepN[0] ;
            n47PesDepN = T000124_n47PesDepN[0] ;
            ZM012( -17) ;
         }
         pr_default.close(22);
         OnLoadActions012( ) ;
      }

      protected void OnLoadActions012( )
      {
      }

      protected void CheckExtendedTable012( )
      {
         Gx_BScreen = 1 ;
         standaloneModal012( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A46PesDepC});
         if ( (pr_default.getStatus(2) == 101) )
         {
            pushError( "Não existe 'Dependente de pessoa.'." );
            AnyError = 1 ;
            setNextFocus( new GXSubfileCell(subDepgrid, nGXsfl_39_idx - 1, 0) );
         }
         A47PesDepN = T00014_A47PesDepN[0] ;
         n47PesDepN = T00014_n47PesDepN[0] ;
         pr_default.close(2);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors012( )
      {
         pr_default.close(2);
      }

      protected void enableDisable012( )
      {
      }

      protected void GetKey012( )
      {
         /* Using cursor T000125 */
         pr_default.execute(23, new Object[] {A13PesCodi, A46PesDepC});
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound2 = 1 ;
         }
         else
         {
            RcdFound2 = 0 ;
         }
         pr_default.close(23);
      }

      protected void getByPrimaryKey012( )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {A13PesCodi, A46PesDepC});
         if ( (pr_default.getStatus(5) != 101) && ( T00017_A13PesCodi[0] == A13PesCodi ) )
         {
            ZM012( 17) ;
            RcdFound2 = 1 ;
            InitializeNonKey012( ) ;
            A46PesDepC = T00017_A46PesDepC[0] ;
            Z13PesCodi = A13PesCodi ;
            Z46PesDepC = A46PesDepC ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load012( ) ;
            Gx_mode = sMode2 ;
         }
         else
         {
            RcdFound2 = 0 ;
            InitializeNonKey012( ) ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal012( ) ;
            Gx_mode = sMode2 ;
         }
         K46PesDepC = A46PesDepC ;
         pr_default.close(5);
      }

      protected void CheckOptimisticConcurrency012( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00016 */
            pr_default.execute(4, new Object[] {A13PesCodi, A46PesDepC});
            if ( ! (pr_default.getStatus(4) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"CLIENTEDEPENDENTE"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            if ( (pr_default.getStatus(4) == 101) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"CLIENTEDEPENDENTE"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert012( )
      {
         BeforeValidate012( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable012( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM012( 0) ;
            CheckOptimisticConcurrency012( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm012( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert012( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000126 */
                     pr_default.execute(24, new Object[] {A13PesCodi, A46PesDepC});
                     pr_default.close(24);
                     if ( (pr_default.getStatus(24) == 1) )
                     {
                        pushError( GXResourceManager.GetMessage("noupdate") );
                        AnyError = 1 ;
                        keepFocus();
                     }
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
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
               Load012( ) ;
            }
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void Update012( )
      {
         BeforeValidate012( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable012( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency012( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm012( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate012( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* No attributes to update on table [CLIENTEDEPENDENTE] */
                     DeferredUpdate012( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey012( ) ;
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
            EndLevel012( ) ;
         }
         CloseExtendedTableCursors012( ) ;
      }

      protected void DeferredUpdate012( )
      {
      }

      protected void Delete012( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate012( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency012( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls012( ) ;
            /* No cascading delete specified. */
            AfterConfirm012( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete012( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000127 */
                  pr_default.execute(25, new Object[] {A13PesCodi, A46PesDepC});
                  pr_default.close(25);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
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
         sMode2 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel012( ) ;
         Gx_mode = sMode2 ;
      }

      protected void OnDeleteControls012( )
      {
         standaloneModal012( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000128 */
            pr_default.execute(26, new Object[] {A46PesDepC});
            A47PesDepN = T000128_A47PesDepN[0] ;
            n47PesDepN = T000128_n47PesDepN[0] ;
            pr_default.close(26);
         }
      }

      protected void EndLevel012( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(4);
         }
      }

      protected void ScanStart012( )
      {
         /* Using cursor T000129 */
         pr_default.execute(27, new Object[] {A13PesCodi});
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound2 = 1 ;
            A46PesDepC = T000129_A46PesDepC[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext012( )
      {
         pr_default.readNext(27);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound2 = 1 ;
            A46PesDepC = T000129_A46PesDepC[0] ;
         }
      }

      protected void ScanEnd012( )
      {
         pr_default.close(27);
      }

      protected void AfterConfirm012( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert012( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate012( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete012( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete012( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate012( )
      {
         /* Before Validate Rules */
      }

      protected void AddRow012( )
      {
         loadToBuffer39();
      }

      protected void ReadRow012( )
      {
         subtcliente39 = ( subtcliente39 ) subDepgrid.getElementAt(nGXsfl_39_idx) ;
         subfileToVariables39 ();
         nGXsfl_39_idx = (short)(nGXsfl_39_idx+1) ;
      }

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            /* Save parent mode. */
            sMode1 = Gx_mode ;
            CONFIRM_012( ) ;
            if ( ( AnyError == 0 ) )
            {
               /* Restore parent mode. */
               Gx_mode = sMode1 ;
               PreviousCaption = bttBtn_enter.getCaption() ;
               PreviousTooltip = bttBtn_enter.getTooltip() ;
               IsConfirmed = 1 ;
            }
            /* Restore parent mode. */
            Gx_mode = sMode1 ;
         }
      }

      protected void CONFIRM_012( )
      {
         s48PesDepT = O48PesDepT ;
         nGXsfl_39_idx = 0 ;
         while ( ( nGXsfl_39_idx < subDepgrid.getItemCount() ) )
         {
            ReadRow012( ) ;
            if ( ( subtcliente39.isLoaded() != 0 ) || ( subtcliente39.isChanged() != 0 ) )
            {
               GetKey012( ) ;
               if ( ( subtcliente39.isLoaded() == 0 ) && ( subtcliente39.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound2 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     BeforeValidate012( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        CheckExtendedTable012( ) ;
                        CloseExtendedTableCursors012( ) ;
                        if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                        {
                           PreviousCaption = bttBtn_enter.getCaption() ;
                           PreviousTooltip = bttBtn_enter.getTooltip() ;
                           IsConfirmed = 1 ;
                        }
                        O48PesDepT = A48PesDepT ;
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtPesCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound2 != 0 ) )
                  {
                     if ( ( subtcliente39.isDeleted() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        getByPrimaryKey012( ) ;
                        Load012( ) ;
                        BeforeValidate012( ) ;
                        if ( ( AnyError == 0 ) )
                        {
                           OnDeleteControls012( ) ;
                           O48PesDepT = A48PesDepT ;
                        }
                     }
                     else
                     {
                        if ( ( subtcliente39.isChanged() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           BeforeValidate012( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              CheckExtendedTable012( ) ;
                              CloseExtendedTableCursors012( ) ;
                              if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                              {
                                 PreviousCaption = bttBtn_enter.getCaption() ;
                                 PreviousTooltip = bttBtn_enter.getTooltip() ;
                                 IsConfirmed = 1 ;
                              }
                              O48PesDepT = A48PesDepT ;
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtcliente39.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtPesCodigo );
                     }
                  }
               }
            }
         }
         subDepgrid.endLoad();
         O48PesDepT = s48PesDepT ;
         /* Start of After( level) rules */
         /* End of After( level) rules */
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
         pr_default.close(5);
         pr_default.close(26);
         pr_default.close(7);
         pr_default.close(16);
         pr_default.close(17);
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
         A12EstNome = "" ;
         n12EstNome = false ;
         A26CidCodi = 0 ;
         n26CidCodi = false ;
         A27CidNome = "" ;
         n27CidNome = false ;
         A17PesEnde = "" ;
         n17PesEnde = false ;
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
         A83Depende = 0 ;
         n83Depende = false ;
         A112DepVal = "" ;
         n112DepVal = false ;
         A48PesDepT = 0 ;
         i38PesTipo = 0 ;
         A46PesDepC = 0 ;
         A47PesDepN = "" ;
         n47PesDepN = false ;
         K46PesDepC = 0 ;
         subtcliente39 = new subtcliente39();
         sMode2 = "" ;
         lastAnyError = 0 ;
         O48PesDepT = 0 ;
         scmdbuf = "" ;
         T00012_A25EstUF = new String[] {""} ;
         T00012_n25EstUF = new bool[] {false} ;
         T00012_A12EstNome = new String[] {""} ;
         T00012_n12EstNome = new bool[] {false} ;
         T00013_A27CidNome = new String[] {""} ;
         T00013_n27CidNome = new bool[] {false} ;
         T00013_A24EstCodi = new int[1] ;
         T00013_n24EstCodi = new bool[] {false} ;
         T00014_A83Depende = new short[1] ;
         T00014_n83Depende = new bool[] {false} ;
         T00014_A47PesDepN = new String[] {""} ;
         T00014_n47PesDepN = new bool[] {false} ;
         AV12TratEr = "" ;
         Gx_cnt = 0 ;
         T00015_Gx_cnt = new int[1] ;
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
         Z83Depende = 0 ;
         Z112DepVal = "" ;
         Z26CidCodi = 0 ;
         GX_JID = 0 ;
         Z13PesCodi = 0 ;
         T000110_A13PesCodi = new int[1] ;
         T000110_A38PesTipo = new short[1] ;
         T000110_n38PesTipo = new bool[] {false} ;
         T000110_A14PesNome = new String[] {""} ;
         T000110_n14PesNome = new bool[] {false} ;
         T000110_A15PesCPF = new String[] {""} ;
         T000110_n15PesCPF = new bool[] {false} ;
         T000110_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         T000110_n111PesDat = new bool[] {false} ;
         T000110_A25EstUF = new String[] {""} ;
         T000110_n25EstUF = new bool[] {false} ;
         T000110_A12EstNome = new String[] {""} ;
         T000110_n12EstNome = new bool[] {false} ;
         T000110_A27CidNome = new String[] {""} ;
         T000110_n27CidNome = new bool[] {false} ;
         T000110_A17PesEnde = new String[] {""} ;
         T000110_n17PesEnde = new bool[] {false} ;
         T000110_A18PesEndN = new String[] {""} ;
         T000110_n18PesEndN = new bool[] {false} ;
         T000110_A19PesBair = new String[] {""} ;
         T000110_n19PesBair = new bool[] {false} ;
         T000110_A20PesEmai = new String[] {""} ;
         T000110_n20PesEmai = new bool[] {false} ;
         T000110_A21PesTele = new String[] {""} ;
         T000110_n21PesTele = new bool[] {false} ;
         T000110_A22PesCelu = new String[] {""} ;
         T000110_n22PesCelu = new bool[] {false} ;
         T000110_A23PesSitu = new short[1] ;
         T000110_n23PesSitu = new bool[] {false} ;
         T000110_A83Depende = new short[1] ;
         T000110_n83Depende = new bool[] {false} ;
         T000110_A112DepVal = new String[] {""} ;
         T000110_n112DepVal = new bool[] {false} ;
         T000110_A26CidCodi = new int[1] ;
         T000110_n26CidCodi = new bool[] {false} ;
         T000110_A24EstCodi = new int[1] ;
         T000110_n24EstCodi = new bool[] {false} ;
         Gx_BScreen = 0 ;
         T000111_A13PesCodi = new int[1] ;
         T00019_A13PesCodi = new int[1] ;
         T00019_A38PesTipo = new short[1] ;
         T00019_n38PesTipo = new bool[] {false} ;
         T00019_A14PesNome = new String[] {""} ;
         T00019_n14PesNome = new bool[] {false} ;
         T00019_A15PesCPF = new String[] {""} ;
         T00019_n15PesCPF = new bool[] {false} ;
         T00019_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         T00019_n111PesDat = new bool[] {false} ;
         T00019_A17PesEnde = new String[] {""} ;
         T00019_n17PesEnde = new bool[] {false} ;
         T00019_A18PesEndN = new String[] {""} ;
         T00019_n18PesEndN = new bool[] {false} ;
         T00019_A19PesBair = new String[] {""} ;
         T00019_n19PesBair = new bool[] {false} ;
         T00019_A20PesEmai = new String[] {""} ;
         T00019_n20PesEmai = new bool[] {false} ;
         T00019_A21PesTele = new String[] {""} ;
         T00019_n21PesTele = new bool[] {false} ;
         T00019_A22PesCelu = new String[] {""} ;
         T00019_n22PesCelu = new bool[] {false} ;
         T00019_A23PesSitu = new short[1] ;
         T00019_n23PesSitu = new bool[] {false} ;
         T00019_A83Depende = new short[1] ;
         T00019_n83Depende = new bool[] {false} ;
         T00019_A112DepVal = new String[] {""} ;
         T00019_n112DepVal = new bool[] {false} ;
         T00019_A26CidCodi = new int[1] ;
         T00019_n26CidCodi = new bool[] {false} ;
         RcdFound2 = 0 ;
         T000112_A13PesCodi = new int[1] ;
         T000113_A13PesCodi = new int[1] ;
         T00018_A13PesCodi = new int[1] ;
         T00018_A38PesTipo = new short[1] ;
         T00018_n38PesTipo = new bool[] {false} ;
         T00018_A14PesNome = new String[] {""} ;
         T00018_n14PesNome = new bool[] {false} ;
         T00018_A15PesCPF = new String[] {""} ;
         T00018_n15PesCPF = new bool[] {false} ;
         T00018_A111PesDat = new DateTime[] {DateTime.MinValue} ;
         T00018_n111PesDat = new bool[] {false} ;
         T00018_A17PesEnde = new String[] {""} ;
         T00018_n17PesEnde = new bool[] {false} ;
         T00018_A18PesEndN = new String[] {""} ;
         T00018_n18PesEndN = new bool[] {false} ;
         T00018_A19PesBair = new String[] {""} ;
         T00018_n19PesBair = new bool[] {false} ;
         T00018_A20PesEmai = new String[] {""} ;
         T00018_n20PesEmai = new bool[] {false} ;
         T00018_A21PesTele = new String[] {""} ;
         T00018_n21PesTele = new bool[] {false} ;
         T00018_A22PesCelu = new String[] {""} ;
         T00018_n22PesCelu = new bool[] {false} ;
         T00018_A23PesSitu = new short[1] ;
         T00018_n23PesSitu = new bool[] {false} ;
         T00018_A83Depende = new short[1] ;
         T00018_n83Depende = new bool[] {false} ;
         T00018_A112DepVal = new String[] {""} ;
         T00018_n112DepVal = new bool[] {false} ;
         T00018_A26CidCodi = new int[1] ;
         T00018_n26CidCodi = new bool[] {false} ;
         Gx_longc = false ;
         T000115_A13PesCodi = new int[1] ;
         T000118_A27CidNome = new String[] {""} ;
         T000118_n27CidNome = new bool[] {false} ;
         T000118_A24EstCodi = new int[1] ;
         T000118_n24EstCodi = new bool[] {false} ;
         T000119_A25EstUF = new String[] {""} ;
         T000119_n25EstUF = new bool[] {false} ;
         T000119_A12EstNome = new String[] {""} ;
         T000119_n12EstNome = new bool[] {false} ;
         T000120_A86LocCodi = new int[1] ;
         T000121_A86LocCodi = new int[1] ;
         T000122_A13PesCodi = new int[1] ;
         T000122_A46PesDepC = new int[1] ;
         s48PesDepT = 0 ;
         T00017_A13PesCodi = new int[1] ;
         T00017_A46PesDepC = new int[1] ;
         T000123_A13PesCodi = new int[1] ;
         Z46PesDepC = 0 ;
         T000124_A13PesCodi = new int[1] ;
         T000124_A83Depende = new short[1] ;
         T000124_n83Depende = new bool[] {false} ;
         T000124_A47PesDepN = new String[] {""} ;
         T000124_n47PesDepN = new bool[] {false} ;
         T000124_A46PesDepC = new int[1] ;
         T000125_A13PesCodi = new int[1] ;
         T000125_A46PesDepC = new int[1] ;
         T00016_A13PesCodi = new int[1] ;
         T00016_A46PesDepC = new int[1] ;
         T000128_A83Depende = new short[1] ;
         T000128_n83Depende = new bool[] {false} ;
         T000128_A47PesDepN = new String[] {""} ;
         T000128_n47PesDepN = new bool[] {false} ;
         T000129_A13PesCodi = new int[1] ;
         T000129_A46PesDepC = new int[1] ;
         K13PesCodi = 0 ;
         A83Depende = 0 ;
         n83Depende = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tcliente__default(),
            new Object[][] {
                new Object[] {
               T00012_A25EstUF, T00012_n25EstUF, T00012_A12EstNome, T00012_n12EstNome
               }
               , new Object[] {
               T00013_A27CidNome, T00013_n27CidNome, T00013_A24EstCodi, T00013_n24EstCodi
               }
               , new Object[] {
               T00014_A83Depende, T00014_n83Depende, T00014_A47PesDepN, T00014_n47PesDepN
               }
               , new Object[] {
               T00015_Gx_cnt
               }
               , new Object[] {
               T00016_A13PesCodi, T00016_A46PesDepC
               }
               , new Object[] {
               T00017_A13PesCodi, T00017_A46PesDepC
               }
               , new Object[] {
               T00018_A13PesCodi, T00018_A38PesTipo, T00018_n38PesTipo, T00018_A14PesNome, T00018_n14PesNome, T00018_A15PesCPF, T00018_n15PesCPF, T00018_A111PesDat, T00018_n111PesDat, T00018_A17PesEnde,
               T00018_n17PesEnde, T00018_A18PesEndN, T00018_n18PesEndN, T00018_A19PesBair, T00018_n19PesBair, T00018_A20PesEmai, T00018_n20PesEmai, T00018_A21PesTele, T00018_n21PesTele, T00018_A22PesCelu,
               T00018_n22PesCelu, T00018_A23PesSitu, T00018_n23PesSitu, T00018_A83Depende, T00018_n83Depende, T00018_A112DepVal, T00018_n112DepVal, T00018_A26CidCodi, T00018_n26CidCodi
               }
               , new Object[] {
               T00019_A13PesCodi, T00019_A38PesTipo, T00019_n38PesTipo, T00019_A14PesNome, T00019_n14PesNome, T00019_A15PesCPF, T00019_n15PesCPF, T00019_A111PesDat, T00019_n111PesDat, T00019_A17PesEnde,
               T00019_n17PesEnde, T00019_A18PesEndN, T00019_n18PesEndN, T00019_A19PesBair, T00019_n19PesBair, T00019_A20PesEmai, T00019_n20PesEmai, T00019_A21PesTele, T00019_n21PesTele, T00019_A22PesCelu,
               T00019_n22PesCelu, T00019_A23PesSitu, T00019_n23PesSitu, T00019_A83Depende, T00019_n83Depende, T00019_A112DepVal, T00019_n112DepVal, T00019_A26CidCodi, T00019_n26CidCodi
               }
               , new Object[] {
               T000110_A13PesCodi, T000110_A38PesTipo, T000110_n38PesTipo, T000110_A14PesNome, T000110_n14PesNome, T000110_A15PesCPF, T000110_n15PesCPF, T000110_A111PesDat, T000110_n111PesDat, T000110_A25EstUF,
               T000110_n25EstUF, T000110_A12EstNome, T000110_n12EstNome, T000110_A27CidNome, T000110_n27CidNome, T000110_A17PesEnde, T000110_n17PesEnde, T000110_A18PesEndN, T000110_n18PesEndN, T000110_A19PesBair,
               T000110_n19PesBair, T000110_A20PesEmai, T000110_n20PesEmai, T000110_A21PesTele, T000110_n21PesTele, T000110_A22PesCelu, T000110_n22PesCelu, T000110_A23PesSitu, T000110_n23PesSitu, T000110_A83Depende,
               T000110_n83Depende, T000110_A112DepVal, T000110_n112DepVal, T000110_A26CidCodi, T000110_n26CidCodi, T000110_A24EstCodi, T000110_n24EstCodi
               }
               , new Object[] {
               T000111_A13PesCodi
               }
               , new Object[] {
               T000112_A13PesCodi
               }
               , new Object[] {
               T000113_A13PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000115_A13PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000118_A27CidNome, T000118_n27CidNome, T000118_A24EstCodi, T000118_n24EstCodi
               }
               , new Object[] {
               T000119_A25EstUF, T000119_n25EstUF, T000119_A12EstNome, T000119_n12EstNome
               }
               , new Object[] {
               T000120_A86LocCodi
               }
               , new Object[] {
               T000121_A86LocCodi
               }
               , new Object[] {
               T000122_A13PesCodi, T000122_A46PesDepC
               }
               , new Object[] {
               T000123_A13PesCodi
               }
               , new Object[] {
               T000124_A13PesCodi, T000124_A83Depende, T000124_n83Depende, T000124_A47PesDepN, T000124_n47PesDepN, T000124_A46PesDepC
               }
               , new Object[] {
               T000125_A13PesCodi, T000125_A46PesDepC
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000128_A83Depende, T000128_n83Depende, T000128_A47PesDepN, T000128_n47PesDepN
               }
               , new Object[] {
               T000129_A13PesCodi, T000129_A46PesDepC
               }
            }
         );
         reloadDynamicLists(0);
         K13PesCodi = 0 ;
         edtPesCodigo.setValue(A13PesCodi);
         A83Depende = 0 ;
         chkDepende.setValue(A83Depende);
         n83Depende = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A38PesTipo ;
      protected short A23PesSitu ;
      protected short A83Depende ;
      protected short geteqAfterKey= 1 ;
      protected short i38PesTipo ;
      protected short geteqAfterKey2= 1 ;
      protected short RcdFound1 ;
      protected short Z38PesTipo ;
      protected short Z23PesSitu ;
      protected short Z83Depende ;
      protected short Gx_BScreen ;
      protected short RcdFound2 ;
      protected short nGXsfl_39_idx=1 ;
      protected int trnEnded ;
      protected int A24EstCodi ;
      protected int A26CidCodi ;
      protected int A48PesDepT ;
      protected int K13PesCodi ;
      protected int A13PesCodi ;
      protected int A46PesDepC ;
      protected int K46PesDepC ;
      protected int lastAnyError ;
      protected int O48PesDepT ;
      protected int Gx_cnt ;
      protected int E13PesCodi ;
      protected int Z26CidCodi ;
      protected int GX_JID ;
      protected int Z13PesCodi ;
      protected int s48PesDepT ;
      protected int Z46PesDepC ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String A25EstUF ;
      protected String sMode2 ;
      protected String scmdbuf ;
      protected String sMode1 ;
      protected DateTime A111PesDat ;
      protected DateTime Z111PesDat ;
      protected bool n38PesTipo ;
      protected bool n14PesNome ;
      protected bool n15PesCPF ;
      protected bool n111PesDat ;
      protected bool n24EstCodi ;
      protected bool n25EstUF ;
      protected bool n12EstNome ;
      protected bool n26CidCodi ;
      protected bool n27CidNome ;
      protected bool n17PesEnde ;
      protected bool n18PesEndN ;
      protected bool n19PesBair ;
      protected bool n20PesEmai ;
      protected bool n21PesTele ;
      protected bool n22PesCelu ;
      protected bool n23PesSitu ;
      protected bool n83Depende ;
      protected bool n112DepVal ;
      protected bool n47PesDepN ;
      protected bool Gx_longc ;
      protected String A14PesNome ;
      protected String A15PesCPF ;
      protected String A12EstNome ;
      protected String A27CidNome ;
      protected String A17PesEnde ;
      protected String A18PesEndN ;
      protected String A19PesBair ;
      protected String A20PesEmai ;
      protected String A21PesTele ;
      protected String A22PesCelu ;
      protected String A112DepVal ;
      protected String A47PesDepN ;
      protected String AV12TratEr ;
      protected String Z14PesNome ;
      protected String Z15PesCPF ;
      protected String Z17PesEnde ;
      protected String Z18PesEndN ;
      protected String Z19PesBair ;
      protected String Z20PesEmai ;
      protected String Z21PesTele ;
      protected String Z22PesCelu ;
      protected String Z112DepVal ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected IGXButton bttBtn_movimentos ;
      protected IGXButton bttBtn_enter ;
      protected GXTabControl tctrlCadastrodecliente ;
      protected GXTabPage tpagetpage3 ;
      protected GUIObjectInt edtPesCodigo ;
      protected GUIObjectString edtPesNome ;
      protected GUIObjectDatetime edtPesDatNascimento ;
      protected GUIObjectString edtPesCPF ;
      protected GUIObjectString edtPesEndereco ;
      protected GUIObjectString edtPesEndNumero ;
      protected GUIObjectString edtPesBairro ;
      protected GUIObjectString edtPesEmail ;
      protected GUIObjectString edtPesTelefone ;
      protected GUIObjectString edtPesCelular ;
      protected GUIObjectShort cmbPesSituacao ;
      protected GUIObjectInt edtEstCodigo ;
      protected GUIObjectString edtEstUF ;
      protected GUIObjectString edtEstNome ;
      protected GUIObjectInt edtCidCodigo ;
      protected GUIObjectString edtCidNome ;
      protected GUIObjectShort chkDepende ;
      protected ILabel lbllbl36 ;
      protected ILabel lbllbl35 ;
      protected ILabel lbllbl31 ;
      protected ILabel lbllbl29 ;
      protected ILabel lbllbl33 ;
      protected ILabel lbllbl27 ;
      protected ILabel lbllbl25 ;
      protected ILabel lbllbl23 ;
      protected ILabel lbllbl21 ;
      protected ILabel lbllbl19 ;
      protected ILabel lbllbl17 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl6 ;
      protected GXTabPage tpagetpage38 ;
      protected GXSubfileTRN subDepgrid ;
      protected ILabel lbllbl42 ;
      protected subtcliente39 subtcliente39 ;
      protected IDataReader T00012 ;
      protected IDataStoreProvider pr_default ;
      protected String[] T00012_A25EstUF ;
      protected bool[] T00012_n25EstUF ;
      protected String[] T00012_A12EstNome ;
      protected bool[] T00012_n12EstNome ;
      protected IDataReader T00013 ;
      protected String[] T00013_A27CidNome ;
      protected bool[] T00013_n27CidNome ;
      protected int[] T00013_A24EstCodi ;
      protected bool[] T00013_n24EstCodi ;
      protected IDataReader T00014 ;
      protected short[] T00014_A83Depende ;
      protected bool[] T00014_n83Depende ;
      protected String[] T00014_A47PesDepN ;
      protected bool[] T00014_n47PesDepN ;
      protected IDataReader T00015 ;
      protected int[] T00015_Gx_cnt ;
      protected IDataReader T00016 ;
      protected IDataReader T00017 ;
      protected IDataReader T00018 ;
      protected IDataReader T00019 ;
      protected IDataReader T000110 ;
      protected int[] T000110_A13PesCodi ;
      protected short[] T000110_A38PesTipo ;
      protected bool[] T000110_n38PesTipo ;
      protected String[] T000110_A14PesNome ;
      protected bool[] T000110_n14PesNome ;
      protected String[] T000110_A15PesCPF ;
      protected bool[] T000110_n15PesCPF ;
      protected DateTime[] T000110_A111PesDat ;
      protected bool[] T000110_n111PesDat ;
      protected String[] T000110_A25EstUF ;
      protected bool[] T000110_n25EstUF ;
      protected String[] T000110_A12EstNome ;
      protected bool[] T000110_n12EstNome ;
      protected String[] T000110_A27CidNome ;
      protected bool[] T000110_n27CidNome ;
      protected String[] T000110_A17PesEnde ;
      protected bool[] T000110_n17PesEnde ;
      protected String[] T000110_A18PesEndN ;
      protected bool[] T000110_n18PesEndN ;
      protected String[] T000110_A19PesBair ;
      protected bool[] T000110_n19PesBair ;
      protected String[] T000110_A20PesEmai ;
      protected bool[] T000110_n20PesEmai ;
      protected String[] T000110_A21PesTele ;
      protected bool[] T000110_n21PesTele ;
      protected String[] T000110_A22PesCelu ;
      protected bool[] T000110_n22PesCelu ;
      protected short[] T000110_A23PesSitu ;
      protected bool[] T000110_n23PesSitu ;
      protected short[] T000110_A83Depende ;
      protected bool[] T000110_n83Depende ;
      protected String[] T000110_A112DepVal ;
      protected bool[] T000110_n112DepVal ;
      protected int[] T000110_A26CidCodi ;
      protected bool[] T000110_n26CidCodi ;
      protected int[] T000110_A24EstCodi ;
      protected bool[] T000110_n24EstCodi ;
      protected IDataReader T000111 ;
      protected int[] T000111_A13PesCodi ;
      protected int[] T00019_A13PesCodi ;
      protected short[] T00019_A38PesTipo ;
      protected bool[] T00019_n38PesTipo ;
      protected String[] T00019_A14PesNome ;
      protected bool[] T00019_n14PesNome ;
      protected String[] T00019_A15PesCPF ;
      protected bool[] T00019_n15PesCPF ;
      protected DateTime[] T00019_A111PesDat ;
      protected bool[] T00019_n111PesDat ;
      protected String[] T00019_A17PesEnde ;
      protected bool[] T00019_n17PesEnde ;
      protected String[] T00019_A18PesEndN ;
      protected bool[] T00019_n18PesEndN ;
      protected String[] T00019_A19PesBair ;
      protected bool[] T00019_n19PesBair ;
      protected String[] T00019_A20PesEmai ;
      protected bool[] T00019_n20PesEmai ;
      protected String[] T00019_A21PesTele ;
      protected bool[] T00019_n21PesTele ;
      protected String[] T00019_A22PesCelu ;
      protected bool[] T00019_n22PesCelu ;
      protected short[] T00019_A23PesSitu ;
      protected bool[] T00019_n23PesSitu ;
      protected short[] T00019_A83Depende ;
      protected bool[] T00019_n83Depende ;
      protected String[] T00019_A112DepVal ;
      protected bool[] T00019_n112DepVal ;
      protected int[] T00019_A26CidCodi ;
      protected bool[] T00019_n26CidCodi ;
      protected IDataReader T000112 ;
      protected int[] T000112_A13PesCodi ;
      protected IDataReader T000113 ;
      protected int[] T000113_A13PesCodi ;
      protected int[] T00018_A13PesCodi ;
      protected short[] T00018_A38PesTipo ;
      protected bool[] T00018_n38PesTipo ;
      protected String[] T00018_A14PesNome ;
      protected bool[] T00018_n14PesNome ;
      protected String[] T00018_A15PesCPF ;
      protected bool[] T00018_n15PesCPF ;
      protected DateTime[] T00018_A111PesDat ;
      protected bool[] T00018_n111PesDat ;
      protected String[] T00018_A17PesEnde ;
      protected bool[] T00018_n17PesEnde ;
      protected String[] T00018_A18PesEndN ;
      protected bool[] T00018_n18PesEndN ;
      protected String[] T00018_A19PesBair ;
      protected bool[] T00018_n19PesBair ;
      protected String[] T00018_A20PesEmai ;
      protected bool[] T00018_n20PesEmai ;
      protected String[] T00018_A21PesTele ;
      protected bool[] T00018_n21PesTele ;
      protected String[] T00018_A22PesCelu ;
      protected bool[] T00018_n22PesCelu ;
      protected short[] T00018_A23PesSitu ;
      protected bool[] T00018_n23PesSitu ;
      protected short[] T00018_A83Depende ;
      protected bool[] T00018_n83Depende ;
      protected String[] T00018_A112DepVal ;
      protected bool[] T00018_n112DepVal ;
      protected int[] T00018_A26CidCodi ;
      protected bool[] T00018_n26CidCodi ;
      protected IDataReader T000115 ;
      protected int[] T000115_A13PesCodi ;
      protected IDataReader T000118 ;
      protected String[] T000118_A27CidNome ;
      protected bool[] T000118_n27CidNome ;
      protected int[] T000118_A24EstCodi ;
      protected bool[] T000118_n24EstCodi ;
      protected IDataReader T000119 ;
      protected String[] T000119_A25EstUF ;
      protected bool[] T000119_n25EstUF ;
      protected String[] T000119_A12EstNome ;
      protected bool[] T000119_n12EstNome ;
      protected IDataReader T000120 ;
      protected int[] T000120_A86LocCodi ;
      protected IDataReader T000121 ;
      protected int[] T000121_A86LocCodi ;
      protected IDataReader T000122 ;
      protected int[] T000122_A13PesCodi ;
      protected int[] T000122_A46PesDepC ;
      protected int[] T00017_A13PesCodi ;
      protected int[] T00017_A46PesDepC ;
      protected IDataReader T000123 ;
      protected int[] T000123_A13PesCodi ;
      protected IDataReader T000124 ;
      protected int[] T000124_A13PesCodi ;
      protected short[] T000124_A83Depende ;
      protected bool[] T000124_n83Depende ;
      protected String[] T000124_A47PesDepN ;
      protected bool[] T000124_n47PesDepN ;
      protected int[] T000124_A46PesDepC ;
      protected IDataReader T000125 ;
      protected int[] T000125_A13PesCodi ;
      protected int[] T000125_A46PesDepC ;
      protected int[] T00016_A13PesCodi ;
      protected int[] T00016_A46PesDepC ;
      protected IDataReader T000128 ;
      protected short[] T000128_A83Depende ;
      protected bool[] T000128_n83Depende ;
      protected String[] T000128_A47PesDepN ;
      protected bool[] T000128_n47PesDepN ;
      protected IDataReader T000129 ;
      protected int[] T000129_A13PesCodi ;
      protected int[] T000129_A46PesDepC ;
   }

   public class tcliente__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[8])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[9])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[10])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[11])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[14])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[15])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[16])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[17])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[18])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[19])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[20])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[21])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[22])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[23])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[24])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[25])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[26])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[27])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
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
          new Object[] {"@Depende",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DepValidacao",SqlDbType.VarChar,1,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
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
          new Object[] {"@Depende",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@DepValidacao",SqlDbType.VarChar,1,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000122 ;
          prmT000122 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000123 ;
          prmT000123 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000124 ;
          prmT000124 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000125 ;
          prmT000125 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000126 ;
          prmT000126 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000127 ;
          prmT000127 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000128 ;
          prmT000128 = new Object[] {
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000129 ;
          prmT000129 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00012", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00013", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00014", "SELECT [Depende], [PesNome] AS PesDepNome FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesDepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00015", "SELECT COUNT(*) FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00016", "SELECT [PesCodigo], [PesDepCodigo] AS PesDepCodigo FROM [CLIENTEDEPENDENTE] WITH (UPDLOCK) WHERE [PesCodigo] = @PesCodigo AND [PesDepCodigo] = @PesDepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00017", "SELECT [PesCodigo], [PesDepCodigo] AS PesDepCodigo FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo AND [PesDepCodigo] = @PesDepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00018", "SELECT [PesCodigo], [PesTipo], [PesNome], [PesCPF], [PesDatNascimento], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [Depende], [DepValidacao], [CidCodigo] FROM [PESSOA] WITH (UPDLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00019", "SELECT [PesCodigo], [PesTipo], [PesNome], [PesCPF], [PesDatNascimento], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [Depende], [DepValidacao], [CidCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000110", "SELECT TM1.[PesCodigo], TM1.[PesTipo], TM1.[PesNome], TM1.[PesCPF], TM1.[PesDatNascimento], T3.[EstUF], T3.[EstNome], T2.[CidNome], TM1.[PesEndereco], TM1.[PesEndNumero], TM1.[PesBairro], TM1.[PesEmail], TM1.[PesTelefone], TM1.[PesCelular], TM1.[PesSituacao], TM1.[Depende], TM1.[DepValidacao], TM1.[CidCodigo], T2.[EstCodigo] FROM (([PESSOA] TM1 WITH (NOLOCK) LEFT JOIN [CIDADE] T2 WITH (NOLOCK) ON T2.[CidCodigo] = TM1.[CidCodigo]) LEFT JOIN [ESTADO] T3 WITH (NOLOCK) ON T3.[EstCodigo] = T2.[EstCodigo]) WHERE TM1.[PesCodigo] = @PesCodigo ORDER BY TM1.[PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000111", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000112", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000112,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000113", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000114", "INSERT INTO [PESSOA] ([PesTipo], [PesNome], [PesCPF], [PesDatNascimento], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [Depende], [DepValidacao], [CidCodigo], [PesFunCargo], [PesFunDatAdmissao], [PesFunDatDemissao], [PesFunLogin], [PesFunSenha], [PesFunSalario]) VALUES (@PesTipo, @PesNome, @PesCPF, @PesDatNascimento, @PesEndereco, @PesEndNumero, @PesBairro, @PesEmail, @PesTelefone, @PesCelular, @PesSituacao, @Depende, @DepValidacao, @CidCodigo, convert(int, 0), convert( DATETIME, '17530101', 112 ), convert( DATETIME, '17530101', 112 ), '', '', convert(int, 0))", GxErrorMask.GX_NOMASK,prmT000114)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000115", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000116", "UPDATE [PESSOA] SET [PesTipo]=@PesTipo, [PesNome]=@PesNome, [PesCPF]=@PesCPF, [PesDatNascimento]=@PesDatNascimento, [PesEndereco]=@PesEndereco, [PesEndNumero]=@PesEndNumero, [PesBairro]=@PesBairro, [PesEmail]=@PesEmail, [PesTelefone]=@PesTelefone, [PesCelular]=@PesCelular, [PesSituacao]=@PesSituacao, [Depende]=@Depende, [DepValidacao]=@DepValidacao, [CidCodigo]=@CidCodigo  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000116)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000117", "DELETE FROM [PESSOA]  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000117)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000118", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000119", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000119,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000120", "SELECT TOP 1 [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocVenPesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000120,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000121", "SELECT TOP 1 [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCliPesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000121,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000122", "SELECT TOP 1 [PesCodigo], [PesDepCodigo] AS PesDepCodigo FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesDepCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000122,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000123", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000123,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000124", "SELECT T1.[PesCodigo], T2.[Depende], T2.[PesNome] AS PesDepNome, T1.[PesDepCodigo] AS PesDepCodigo FROM ([CLIENTEDEPENDENTE] T1 WITH (NOLOCK) INNER JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = T1.[PesDepCodigo]) WHERE T1.[PesCodigo] = @PesCodigo and T1.[PesDepCodigo] = @PesDepCodigo ORDER BY T1.[PesCodigo], T1.[PesDepCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000124,13,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000125", "SELECT [PesCodigo], [PesDepCodigo] AS PesDepCodigo FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo AND [PesDepCodigo] = @PesDepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000125,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000126", "INSERT INTO [CLIENTEDEPENDENTE] ([PesCodigo], [PesDepCodigo]) VALUES (@PesCodigo, @PesDepCodigo)", GxErrorMask.GX_NOMASK,prmT000126)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000127", "DELETE FROM [CLIENTEDEPENDENTE]  WHERE [PesCodigo] = @PesCodigo AND [PesDepCodigo] = @PesDepCodigo", GxErrorMask.GX_NOMASK,prmT000127)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000128", "SELECT [Depende], [PesNome] AS PesDepNome FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesDepCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000128,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000129", "SELECT [PesCodigo], [PesDepCodigo] AS PesDepCodigo FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ORDER BY [PesCodigo], [PesDepCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000129,13,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
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
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((int[]) buf[27])[0] = rslt.getInt(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                break;
             case 7 :
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
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((int[]) buf[27])[0] = rslt.getInt(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                break;
             case 8 :
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
                ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((int[]) buf[33])[0] = rslt.getInt(18) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(18);
                ((int[]) buf[35])[0] = rslt.getInt(19) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(19);
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 2) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 18 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 19 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 20 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 21 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 22 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                break;
             case 23 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                break;
             case 27 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
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
                   stmt.setNull( 13 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(14, (int)parms[27]);
                }
                break;
             case 14 :
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
                   stmt.setNull( 13 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[25]);
                }
                if ( (bool)parms[26] )
                {
                   stmt.setNull( 14 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(14, (int)parms[27]);
                }
                stmt.SetParameter(15, (int)parms[28]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 16 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 17 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 18 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 22 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 23 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 24 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 25 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 27 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
