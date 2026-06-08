/*
               File: Pessoa
        Description: Cadastro de pessoas.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 4/10/2026 10:40:43.31
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
   public class tpessoa : GXTransaction
   {
      public tpessoa( int hnd ,
                      ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tpessoa( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tpessoa( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey011( )
      {
         A14PesNome = "" ;
         n14PesNome = false ;
         n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
         A16PesDatN = (DateTime)(DateTime.MinValue) ;
         n16PesDatN = false ;
         n16PesDatN = (((DateTime.MinValue==A16PesDatN)) ? true : false) ;
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
      }

      protected void InitAll011( )
      {
         A13PesCodi = 0 ;
         K13PesCodi = A13PesCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
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
         return "Pessoa" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de pessoas." ;
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
         return 1027 ;
      }

      public override int getFrmHeight( )
      {
         return 741 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TPessoa.htm";
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
         return false;
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

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1027 , 741 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtPesCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),208, 26, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 26 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A13PesCodi" );
         ((GXEdit) edtPesCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtPesCodigo.addFocusListener(this);
         edtPesCodigo.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 52, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 52 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A14PesNome" );
         ((GXEdit) edtPesNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesNome.addFocusListener(this);
         edtPesNome.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesCPF = new GUIObjectString ( new GXEdit(14, "999.999.999-99", UIFactory.getFont( "Courier New", 0, 9),208, 78, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 78 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A15PesCPF" );
         ((GXEdit) edtPesCPF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesCPF.addFocusListener(this);
         edtPesCPF.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesDatNasc = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),208, 104, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 104 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A16PesDatN" );
         ((GXEdit) edtPesDatNasc.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesDatNasc.addFocusListener(this);
         edtPesDatNasc.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesEndereco = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 130, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 130 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A17PesEnde" );
         ((GXEdit) edtPesEndereco.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEndereco.addFocusListener(this);
         edtPesEndereco.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesEndNumero = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 156, 150, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 156 , 150 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A18PesEndN" );
         ((GXEdit) edtPesEndNumero.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEndNumero.addFocusListener(this);
         edtPesEndNumero.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesBairro = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 182, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 182 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A19PesBair" );
         ((GXEdit) edtPesBairro.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesBairro.addFocusListener(this);
         edtPesBairro.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesEmail = new GUIObjectString ( new GXEdit(100, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 208, 430, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 208 , 430 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A20PesEmai" );
         ((GXEdit) edtPesEmail.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesEmail.addFocusListener(this);
         edtPesEmail.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesTelefone = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),208, 234, 101, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 234 , 101 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A21PesTele" );
         ((GXEdit) edtPesTelefone.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesTelefone.addFocusListener(this);
         edtPesTelefone.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtPesCelular = new GUIObjectString ( new GXEdit(13, "(99)9999-9999", UIFactory.getFont( "Courier New", 0, 9),208, 260, 101, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 260 , 101 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A22PesCelu" );
         ((GXEdit) edtPesCelular.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtPesCelular.addFocusListener(this);
         edtPesCelular.getGXComponent().setHelpId("HLP_TPessoa.htm");
         cmbPesSituacao = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 208 , 286 , 75 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A23PesSitu" );
         ((GXComboBox) cmbPesSituacao.getGXComponent()).addItem( new java.lang.Short(1),"Ativo");
         ((GXComboBox) cmbPesSituacao.getGXComponent()).addItem( new java.lang.Short(2),"Inativo");
         cmbPesSituacao.addFocusListener(this);
         cmbPesSituacao.addItemListener(this);
         cmbPesSituacao.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtEstCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),208, 312, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 208 , 312 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" );
         ((GXEdit) edtEstCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtEstCodigo.addFocusListener(this);
         edtEstCodigo.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtEstUF = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),208, 338, 24, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 208 , 338 , 24 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" );
         ((GXEdit) edtEstUF.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstUF.addFocusListener(this);
         edtEstUF.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtEstNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 364, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 208 , 364 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A12EstNome" );
         ((GXEdit) edtEstNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtEstNome.addFocusListener(this);
         edtEstNome.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtCidCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),208, 390, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 390 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A26CidCodi" );
         ((GXEdit) edtCidCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtCidCodigo.addFocusListener(this);
         edtCidCodigo.getGXComponent().setHelpId("HLP_TPessoa.htm");
         edtCidNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),208, 416, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , GXPanel1 , 208 , 416 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A27CidNome" );
         ((GXEdit) edtCidNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtCidNome.addFocusListener(this);
         edtCidNome.getGXComponent().setHelpId("HLP_TPessoa.htm");
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Enter" ,  676 ,  455 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Enter");
         bttBtn_enter.addActionListener(this);
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Nome completo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 52 , 88 , 13 );
         lbllbl8 = UIFactory.getLabel(GXPanel1, "CPF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 78 , 24 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "Data de nascimento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 104 , 114 , 13 );
         lbllbl12 = UIFactory.getLabel(GXPanel1, "Endereço", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 130 , 121 , 13 );
         lbllbl14 = UIFactory.getLabel(GXPanel1, "Número de endereço", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 156 , 119 , 13 );
         lbllbl16 = UIFactory.getLabel(GXPanel1, "Bairro", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 182 , 34 , 13 );
         lbllbl18 = UIFactory.getLabel(GXPanel1, "E-mail", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 208 , 35 , 13 );
         lbllbl20 = UIFactory.getLabel(GXPanel1, "Telefone residencial", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 234 , 116 , 13 );
         lbllbl22 = UIFactory.getLabel(GXPanel1, "Telefone celular", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 260 , 93 , 13 );
         lbllbl24 = UIFactory.getLabel(GXPanel1, "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 286 , 51 , 13 );
         lbllbl26 = UIFactory.getLabel(GXPanel1, "Código do Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 312 , 101 , 13 );
         lbllbl28 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 338 , 17 , 13 );
         lbllbl30 = UIFactory.getLabel(GXPanel1, "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 364 , 40 , 13 );
         lbllbl32 = UIFactory.getLabel(GXPanel1, "Código da cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 390 , 100 , 13 );
         lbllbl34 = UIFactory.getLabel(GXPanel1, "Cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 416 , 40 , 13 );
         edtCidCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtPesCodigo ,
                   edtPesNome ,
                   edtPesCPF ,
                   edtPesDatNasc ,
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
                   bttBtn_enter
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(edtPesCodigo, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey011( ) ;
      }

      protected void disable_std_buttons( )
      {
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
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtPesCodigo.getGXCursor() );
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
         if ( edtPesDatNasc.isEventSource(eventSource) ) {
            setGXCursor( edtPesDatNasc.getGXCursor() );
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
         if ( edtPesBairro.isEventSource(eventSource) ) {
            setGXCursor( edtPesBairro.getGXCursor() );
            return;
         }
         if ( edtPesEmail.isEventSource(eventSource) ) {
            setGXCursor( edtPesEmail.getGXCursor() );
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            setGXCursor( edtPesTelefone.getGXCursor() );
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            setGXCursor( edtPesCelular.getGXCursor() );
            return;
         }
         if ( cmbPesSituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbPesSituacao.getGXCursor() );
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtEstCodigo.getGXCursor() );
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            setGXCursor( edtEstUF.getGXCursor() );
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
         if ( edtCidNome.isEventSource(eventSource) ) {
            setGXCursor( edtCidNome.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtPesDatNasc.isEventSource(eventSource) ) {
            Valid_Pesdatnasc ();
            return;
         }
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            Valid_Pescodigo ();
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
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            A13PesCodi = edtPesCodigo.getValue() ;
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
         if ( edtPesDatNasc.isEventSource(eventSource) ) {
            A16PesDatN = edtPesDatNasc.getValue() ;
            n16PesDatN = (((DateTime.MinValue==A16PesDatN)) ? true : false) ;
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
         if ( edtPesBairro.isEventSource(eventSource) ) {
            A19PesBair = edtPesBairro.getValue() ;
            n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesEmail.isEventSource(eventSource) ) {
            A20PesEmai = edtPesEmail.getValue() ;
            n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesTelefone.isEventSource(eventSource) ) {
            A21PesTele = edtPesTelefone.getValue() ;
            n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtPesCelular.isEventSource(eventSource) ) {
            A22PesCelu = edtPesCelular.getValue() ;
            n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( cmbPesSituacao.isEventSource(eventSource) ) {
            A23PesSitu = cmbPesSituacao.getValue() ;
            n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
            return;
         }
         if ( edtEstCodigo.isEventSource(eventSource) ) {
            A24EstCodi = edtEstCodigo.getValue() ;
            return;
         }
         if ( edtEstUF.isEventSource(eventSource) ) {
            A25EstUF = edtEstUF.getValue() ;
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
         if ( edtCidNome.isEventSource(eventSource) ) {
            A27CidNome = edtCidNome.getValue() ;
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
         if ( ( edtPesNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A14PesNome.TrimEnd(' '), edtPesNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesCPF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A15PesCPF.TrimEnd(' '), edtPesCPF.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesDatNasc.isEventSource(eventSource) ) && ( ( A16PesDatN != edtPesDatNasc.getValue() ) ) )
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
         if ( ( edtPesBairro.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A19PesBair.TrimEnd(' '), edtPesBairro.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesEmail.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A20PesEmai.TrimEnd(' '), edtPesEmail.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesTelefone.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A21PesTele.TrimEnd(' '), edtPesTelefone.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtPesCelular.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A22PesCelu.TrimEnd(' '), edtPesCelular.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( cmbPesSituacao.isEventSource(eventSource) ) && ( ( A23PesSitu != cmbPesSituacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtEstCodigo.isEventSource(eventSource) ) && ( ( A24EstCodi != edtEstCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtEstUF.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A25EstUF.TrimEnd(' '), edtEstUF.getValue().TrimEnd(' ') ) != 0 ) ) )
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
         if ( ( edtCidNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A27CidNome.TrimEnd(' '), edtCidNome.getValue().TrimEnd(' ') ) != 0 ) ) )
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
         bttBtn_enter.setCaption(GXResourceManager.GetMessage("captionadd"));
         bttBtn_enter.setTooltip(GXResourceManager.GetMessage("captionadd"));
      }

      public override IGXButton getConfirmButton( )
      {
         return bttBtn_enter ;
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

      public override void VariablesToControls( )
      {
         edtPesCodigo.setValue( A13PesCodi );
         edtPesNome.setValue( A14PesNome );
         edtPesCPF.setValue( A15PesCPF );
         edtPesDatNasc.setValue( A16PesDatN );
         edtPesEndereco.setValue( A17PesEnde );
         edtPesEndNumero.setValue( A18PesEndN );
         edtPesBairro.setValue( A19PesBair );
         edtPesEmail.setValue( A20PesEmai );
         edtPesTelefone.setValue( A21PesTele );
         edtPesCelular.setValue( A22PesCelu );
         cmbPesSituacao.setValue( A23PesSitu );
         edtEstCodigo.setValue( A24EstCodi );
         edtEstUF.setValue( A25EstUF );
         edtEstNome.setValue( A12EstNome );
         edtCidCodigo.setValue( A26CidCodi );
         edtCidNome.setValue( A27CidNome );
      }

      public override void ControlsToVariables( )
      {
         A13PesCodi = (int)(edtPesCodigo.getValue()) ;
         edtPesCodigo.setValue(A13PesCodi);
         A14PesNome = (String)(edtPesNome.getValue()) ;
         edtPesNome.setValue(A14PesNome);
         n14PesNome = false ;
         n14PesNome = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A14PesNome).TrimEnd(' ') )==0)) ? true : false) ;
         A15PesCPF = (String)(edtPesCPF.getValue()) ;
         edtPesCPF.setValue(A15PesCPF);
         n15PesCPF = false ;
         n15PesCPF = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A15PesCPF).TrimEnd(' ') )==0)) ? true : false) ;
         A16PesDatN = (DateTime)(edtPesDatNasc.getValue()) ;
         edtPesDatNasc.setValue(A16PesDatN);
         n16PesDatN = false ;
         n16PesDatN = (((DateTime.MinValue==A16PesDatN)) ? true : false) ;
         A17PesEnde = (String)(edtPesEndereco.getValue()) ;
         edtPesEndereco.setValue(A17PesEnde);
         n17PesEnde = false ;
         n17PesEnde = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A17PesEnde).TrimEnd(' ') )==0)) ? true : false) ;
         A18PesEndN = (String)(edtPesEndNumero.getValue()) ;
         edtPesEndNumero.setValue(A18PesEndN);
         n18PesEndN = false ;
         n18PesEndN = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A18PesEndN).TrimEnd(' ') )==0)) ? true : false) ;
         A19PesBair = (String)(edtPesBairro.getValue()) ;
         edtPesBairro.setValue(A19PesBair);
         n19PesBair = false ;
         n19PesBair = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A19PesBair).TrimEnd(' ') )==0)) ? true : false) ;
         A20PesEmai = (String)(edtPesEmail.getValue()) ;
         edtPesEmail.setValue(A20PesEmai);
         n20PesEmai = false ;
         n20PesEmai = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A20PesEmai).TrimEnd(' ') )==0)) ? true : false) ;
         A21PesTele = (String)(edtPesTelefone.getValue()) ;
         edtPesTelefone.setValue(A21PesTele);
         n21PesTele = false ;
         n21PesTele = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A21PesTele).TrimEnd(' ') )==0)) ? true : false) ;
         A22PesCelu = (String)(edtPesCelular.getValue()) ;
         edtPesCelular.setValue(A22PesCelu);
         n22PesCelu = false ;
         n22PesCelu = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A22PesCelu).TrimEnd(' ') )==0)) ? true : false) ;
         A23PesSitu = (short)(cmbPesSituacao.getValue()) ;
         cmbPesSituacao.setValue(A23PesSitu);
         n23PesSitu = false ;
         n23PesSitu = (((0==A23PesSitu)) ? true : false) ;
         A24EstCodi = (int)(edtEstCodigo.getValue()) ;
         edtEstCodigo.setValue(A24EstCodi);
         n24EstCodi = false ;
         A25EstUF = (String)(edtEstUF.getValue()) ;
         edtEstUF.setValue(A25EstUF);
         n25EstUF = false ;
         A12EstNome = (String)(edtEstNome.getValue()) ;
         edtEstNome.setValue(A12EstNome);
         n12EstNome = false ;
         A26CidCodi = (int)(edtCidCodigo.getValue()) ;
         edtCidCodigo.setValue(A26CidCodi);
         n26CidCodi = false ;
         n26CidCodi = (((0==A26CidCodi)) ? true : false) ;
         A27CidNome = (String)(edtCidNome.getValue()) ;
         edtCidNome.setValue(A27CidNome);
         n27CidNome = false ;
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
         new wgx0050(context, base.remoteHandle, base.context).execute( out  A26CidCodi) ;
         edtCidCodigo.setValue( A26CidCodi );
         n26CidCodi = false ;
         setFocus(edtCidCodigo);
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

      protected void Valid_Pesdatnasc( )
      {
         if ( ! ( ((DateTime.MinValue==A16PesDatN)) || ( A16PesDatN >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GXutil.msg( me(), "Campo Data de nascimento da pessoa. fora da faixa" );
            AnyError = 1 ;
            setNextFocus( edtPesDatNasc );
            setFocusNext();
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

      /* Server side code */
      /* Aggregate/select formulas */
      /* Vertical formulas */
      public override void standaloneStartupServer( )
      {
         if ( ( AnyError == 0 ) )
         {
            standaloneNotModal( ) ;
            Gx_mode = "INS" ;
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
            }
         }
         set_caption( ) ;
         PreviousCaption = bttBtn_enter.getCaption() ;
      }

      protected void ZM011( int GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z14PesNome = T00015_A14PesNome[0] ;
               Z15PesCPF = T00015_A15PesCPF[0] ;
               Z16PesDatN = T00015_A16PesDatN[0] ;
               Z17PesEnde = T00015_A17PesEnde[0] ;
               Z18PesEndN = T00015_A18PesEndN[0] ;
               Z19PesBair = T00015_A19PesBair[0] ;
               Z20PesEmai = T00015_A20PesEmai[0] ;
               Z21PesTele = T00015_A21PesTele[0] ;
               Z22PesCelu = T00015_A22PesCelu[0] ;
               Z23PesSitu = T00015_A23PesSitu[0] ;
               Z26CidCodi = T00015_A26CidCodi[0] ;
            }
            else
            {
               Z14PesNome = A14PesNome ;
               Z15PesCPF = A15PesCPF ;
               Z16PesDatN = A16PesDatN ;
               Z17PesEnde = A17PesEnde ;
               Z18PesEndN = A18PesEndN ;
               Z19PesBair = A19PesBair ;
               Z20PesEmai = A20PesEmai ;
               Z21PesTele = A21PesTele ;
               Z22PesCelu = A22PesCelu ;
               Z23PesSitu = A23PesSitu ;
               Z26CidCodi = A26CidCodi ;
            }
         }
         if ( ( GX_JID == -2 ) )
         {
            Z13PesCodi = A13PesCodi ;
            Z14PesNome = A14PesNome ;
            Z15PesCPF = A15PesCPF ;
            Z16PesDatN = A16PesDatN ;
            Z17PesEnde = A17PesEnde ;
            Z18PesEndN = A18PesEndN ;
            Z19PesBair = A19PesBair ;
            Z20PesEmai = A20PesEmai ;
            Z21PesTele = A21PesTele ;
            Z22PesCelu = A22PesCelu ;
            Z23PesSitu = A23PesSitu ;
            Z26CidCodi = A26CidCodi ;
         }
      }

      public override void standaloneNotModal( )
      {
      }

      public override void standaloneModal( )
      {
      }

      protected void Load011( )
      {
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1 ;
            A14PesNome = T00016_A14PesNome[0] ;
            n14PesNome = T00016_n14PesNome[0] ;
            A15PesCPF = T00016_A15PesCPF[0] ;
            n15PesCPF = T00016_n15PesCPF[0] ;
            A16PesDatN = T00016_A16PesDatN[0] ;
            n16PesDatN = T00016_n16PesDatN[0] ;
            A17PesEnde = T00016_A17PesEnde[0] ;
            n17PesEnde = T00016_n17PesEnde[0] ;
            A18PesEndN = T00016_A18PesEndN[0] ;
            n18PesEndN = T00016_n18PesEndN[0] ;
            A19PesBair = T00016_A19PesBair[0] ;
            n19PesBair = T00016_n19PesBair[0] ;
            A20PesEmai = T00016_A20PesEmai[0] ;
            n20PesEmai = T00016_n20PesEmai[0] ;
            A21PesTele = T00016_A21PesTele[0] ;
            n21PesTele = T00016_n21PesTele[0] ;
            A22PesCelu = T00016_A22PesCelu[0] ;
            n22PesCelu = T00016_n22PesCelu[0] ;
            A23PesSitu = T00016_A23PesSitu[0] ;
            n23PesSitu = T00016_n23PesSitu[0] ;
            A25EstUF = T00016_A25EstUF[0] ;
            n25EstUF = T00016_n25EstUF[0] ;
            A12EstNome = T00016_A12EstNome[0] ;
            n12EstNome = T00016_n12EstNome[0] ;
            A27CidNome = T00016_A27CidNome[0] ;
            n27CidNome = T00016_n27CidNome[0] ;
            A26CidCodi = T00016_A26CidCodi[0] ;
            n26CidCodi = T00016_n26CidCodi[0] ;
            A24EstCodi = T00016_A24EstCodi[0] ;
            n24EstCodi = T00016_n24EstCodi[0] ;
            ZM011( -2) ;
         }
         pr_default.close(4);
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
         if ( ! ( ((DateTime.MinValue==A16PesDatN)) || ( A16PesDatN >= DateTimeUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            pushError( "Campo Data de nascimento da pessoa. fora da faixa" );
            AnyError = 1 ;
            keepFocus();
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
         /* Using cursor T00017 */
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
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM011( 2) ;
            RcdFound1 = 1 ;
            A13PesCodi = T00015_A13PesCodi[0] ;
            A14PesNome = T00015_A14PesNome[0] ;
            n14PesNome = T00015_n14PesNome[0] ;
            A15PesCPF = T00015_A15PesCPF[0] ;
            n15PesCPF = T00015_n15PesCPF[0] ;
            A16PesDatN = T00015_A16PesDatN[0] ;
            n16PesDatN = T00015_n16PesDatN[0] ;
            A17PesEnde = T00015_A17PesEnde[0] ;
            n17PesEnde = T00015_n17PesEnde[0] ;
            A18PesEndN = T00015_A18PesEndN[0] ;
            n18PesEndN = T00015_n18PesEndN[0] ;
            A19PesBair = T00015_A19PesBair[0] ;
            n19PesBair = T00015_n19PesBair[0] ;
            A20PesEmai = T00015_A20PesEmai[0] ;
            n20PesEmai = T00015_n20PesEmai[0] ;
            A21PesTele = T00015_A21PesTele[0] ;
            n21PesTele = T00015_n21PesTele[0] ;
            A22PesCelu = T00015_A22PesCelu[0] ;
            n22PesCelu = T00015_n22PesCelu[0] ;
            A23PesSitu = T00015_A23PesSitu[0] ;
            n23PesSitu = T00015_n23PesSitu[0] ;
            A26CidCodi = T00015_A26CidCodi[0] ;
            n26CidCodi = T00015_n26CidCodi[0] ;
            Z13PesCodi = A13PesCodi ;
            sMode1 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
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
         pr_default.close(3);
      }

      public override void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00018_A13PesCodi[0] < A13PesCodi ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00018_A13PesCodi[0] > A13PesCodi ) ) )
            {
               A13PesCodi = T00018_A13PesCodi[0] ;
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0 ;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A13PesCodi});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A13PesCodi[0] > A13PesCodi ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A13PesCodi[0] < A13PesCodi ) ) )
            {
               A13PesCodi = T00019_A13PesCodi[0] ;
               RcdFound1 = 1 ;
            }
         }
         pr_default.close(7);
      }

      public override void btn_enter( )
      {
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
               A13PesCodi = Z13PesCodi ;
               edtPesCodigo.setValue(A13PesCodi);
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtPesCodigo );
            }
            else
            {
               Gx_mode = "UPD" ;
               /* Update record */
               Update011( ) ;
               setNextFocus( edtPesCodigo );
            }
         }
         else
         {
            if ( ( A13PesCodi != Z13PesCodi ) )
            {
               Gx_mode = "INS" ;
               /* Insert record */
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
                  Gx_mode = "INS" ;
                  /* Insert record */
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
            A13PesCodi = Z13PesCodi ;
            edtPesCodigo.setValue(A13PesCodi);
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtPesCodigo );
         }
         else
         {
            com.genexus.GXutil.confirm( me(), GXResourceManager.GetMessage("deleinfo") , true );
            if ( GXutil.Confirmed )
            {
               delete( ) ;
               handleErrors();
               AfterTrn( ) ;
               setNextFocus( edtPesCodigo );
            }
         }
         if ( ( AnyError != 0 ) )
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
         CloseOpenCursors();
      }

      public override void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            pushError( GXResourceManager.GetMessage("keynfound") );
            AnyError = 1 ;
            keepFocus();
         }
         setNextFocus( edtPesNome );
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart011( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         setNextFocus( edtPesNome );
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         setNextFocus( edtPesNome );
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         setNextFocus( edtPesNome );
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart011( ) ;
         if ( ( RcdFound1 == 0 ) )
         {
            base.context.msgStatus(GXResourceManager.GetMessage("norectobrow"));
         }
         else
         {
            while ( ( RcdFound1 != 0 ) )
            {
               ScanNext011( ) ;
            }
            Gx_mode = "UPD" ;
         }
         setNextFocus( edtPesNome );
         ScanEnd011( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         if ( ( sanomodError == 0 ) )
         {
            handleErrors();
         }
         setFocusNext();
      }

      public override void btn_select( )
      {
         new wgx0010(context, base.remoteHandle, base.context).execute( out  A13PesCodi) ;
         edtPesCodigo.setValue( A13PesCodi );
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {A13PesCodi});
            if ( ! (pr_default.getStatus(2) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"PESSOA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(2) == 101) || ( String.CompareOrdinal(Z14PesNome.TrimEnd(' '), T00014_A14PesNome[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z15PesCPF.TrimEnd(' '), T00014_A15PesCPF[0].TrimEnd(' ') ) != 0 ) || ( Z16PesDatN != T00014_A16PesDatN[0] ) || ( String.CompareOrdinal(Z17PesEnde.TrimEnd(' '), T00014_A17PesEnde[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z18PesEndN.TrimEnd(' '), T00014_A18PesEndN[0].TrimEnd(' ') ) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( String.CompareOrdinal(Z19PesBair.TrimEnd(' '), T00014_A19PesBair[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z20PesEmai.TrimEnd(' '), T00014_A20PesEmai[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z21PesTele.TrimEnd(' '), T00014_A21PesTele[0].TrimEnd(' ') ) != 0 ) || ( String.CompareOrdinal(Z22PesCelu.TrimEnd(' '), T00014_A22PesCelu[0].TrimEnd(' ') ) != 0 ) || ( Z23PesSitu != T00014_A23PesSitu[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z26CidCodi != T00014_A26CidCodi[0] ) )
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
                     /* Using cursor T000110 */
                     pr_default.execute(8, new Object[] {n14PesNome, A14PesNome, n15PesCPF, A15PesCPF, n16PesDatN, A16PesDatN, n17PesEnde, A17PesEnde, n18PesEndN, A18PesEndN, n19PesBair, A19PesBair, n20PesEmai, A20PesEmai, n21PesTele, A21PesTele, n22PesCelu, A22PesCelu, n23PesSitu, A23PesSitu, n26CidCodi, A26CidCodi});
                     pr_default.close(8);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000111 */
                     pr_default.execute(9);
                     A13PesCodi = T000111_A13PesCodi[0] ;
                     pr_default.close(9);
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           /* Save values for previous() function. */
                           base.context.msgStatus(GXResourceManager.GetMessage("sucadded"));
                           ResetCaption010( ) ;
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
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {n14PesNome, A14PesNome, n15PesCPF, A15PesCPF, n16PesDatN, A16PesDatN, n17PesEnde, A17PesEnde, n18PesEndN, A18PesEndN, n19PesBair, A19PesBair, n20PesEmai, A20PesEmai, n21PesTele, A21PesTele, n22PesCelu, A22PesCelu, n23PesSitu, A23PesSitu, n26CidCodi, A26CidCodi, A13PesCodi});
                     pr_default.close(10);
                     DeferredUpdate011( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey( ) ;
                           base.context.msgStatus(GXResourceManager.GetMessage("sucupdated"));
                           ResetCaption010( ) ;
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
         Gx_mode = "DLT" ;
         BeforeValidate011( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls011( ) ;
            /* No cascading delete specified. */
            AfterConfirm011( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete011( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000113 */
                  pr_default.execute(11, new Object[] {A13PesCodi});
                  pr_default.close(11);
                  if ( ( AnyError == 0 ) )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( ( AnyError == 0 ) )
                     {
                        move_next( ) ;
                        if ( ( RcdFound1 == 0 ) )
                        {
                           InitAll011( ) ;
                           Gx_mode = "INS" ;
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                        }
                        base.context.msgStatus(GXResourceManager.GetMessage("sucdeleted"));
                        ResetCaption010( ) ;
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
         EndLevel011( ) ;
         Gx_mode = sMode1 ;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000114 */
            pr_default.execute(12, new Object[] {n26CidCodi, A26CidCodi});
            A27CidNome = T000114_A27CidNome[0] ;
            n27CidNome = T000114_n27CidNome[0] ;
            A24EstCodi = T000114_A24EstCodi[0] ;
            n24EstCodi = T000114_n24EstCodi[0] ;
            pr_default.close(12);
            /* Using cursor T000115 */
            pr_default.execute(13, new Object[] {n24EstCodi, A24EstCodi});
            A25EstUF = T000115_A25EstUF[0] ;
            n25EstUF = T000115_n25EstUF[0] ;
            A12EstNome = T000115_A12EstNome[0] ;
            n12EstNome = T000115_n12EstNome[0] ;
            pr_default.close(13);
         }
      }

      protected void EndLevel011( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(2);
         }
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete011( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(3);
            pr_default.close(12);
            pr_default.close(13);
            context.CommitDataStores("TPessoa");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(12);
            pr_default.close(13);
            context.RollbackDataStores("TPessoa");
         }
         IsModified = 0 ;
      }

      protected void ScanStart011( )
      {
         /* Using cursor T000116 */
         pr_default.execute(14);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1 ;
            A13PesCodi = T000116_A13PesCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         pr_default.readNext(14);
         RcdFound1 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1 ;
            A13PesCodi = T000116_A13PesCodi[0] ;
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(14);
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
            PreviousCaption = bttBtn_enter.getCaption() ;
            PreviousTooltip = bttBtn_enter.getTooltip() ;
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
         A14PesNome = "" ;
         n14PesNome = false ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         A16PesDatN = (DateTime)(DateTime.MinValue) ;
         n16PesDatN = false ;
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
         A13PesCodi = 0 ;
         K13PesCodi = 0 ;
         lastAnyError = 0 ;
         scmdbuf = "" ;
         T00012_A25EstUF = new String[] {""} ;
         T00012_n25EstUF = new bool[] {false} ;
         T00012_A12EstNome = new String[] {""} ;
         T00012_n12EstNome = new bool[] {false} ;
         T00013_A27CidNome = new String[] {""} ;
         T00013_n27CidNome = new bool[] {false} ;
         T00013_A24EstCodi = new int[1] ;
         T00013_n24EstCodi = new bool[] {false} ;
         Z14PesNome = "" ;
         Z15PesCPF = "" ;
         Z16PesDatN = (DateTime)(DateTime.MinValue) ;
         Z17PesEnde = "" ;
         Z18PesEndN = "" ;
         Z19PesBair = "" ;
         Z20PesEmai = "" ;
         Z21PesTele = "" ;
         Z22PesCelu = "" ;
         Z23PesSitu = 0 ;
         Z26CidCodi = 0 ;
         GX_JID = 0 ;
         Z13PesCodi = 0 ;
         T00016_A13PesCodi = new int[1] ;
         T00016_A14PesNome = new String[] {""} ;
         T00016_n14PesNome = new bool[] {false} ;
         T00016_A15PesCPF = new String[] {""} ;
         T00016_n15PesCPF = new bool[] {false} ;
         T00016_A16PesDatN = new DateTime[] {DateTime.MinValue} ;
         T00016_n16PesDatN = new bool[] {false} ;
         T00016_A17PesEnde = new String[] {""} ;
         T00016_n17PesEnde = new bool[] {false} ;
         T00016_A18PesEndN = new String[] {""} ;
         T00016_n18PesEndN = new bool[] {false} ;
         T00016_A19PesBair = new String[] {""} ;
         T00016_n19PesBair = new bool[] {false} ;
         T00016_A20PesEmai = new String[] {""} ;
         T00016_n20PesEmai = new bool[] {false} ;
         T00016_A21PesTele = new String[] {""} ;
         T00016_n21PesTele = new bool[] {false} ;
         T00016_A22PesCelu = new String[] {""} ;
         T00016_n22PesCelu = new bool[] {false} ;
         T00016_A23PesSitu = new short[1] ;
         T00016_n23PesSitu = new bool[] {false} ;
         T00016_A25EstUF = new String[] {""} ;
         T00016_n25EstUF = new bool[] {false} ;
         T00016_A12EstNome = new String[] {""} ;
         T00016_n12EstNome = new bool[] {false} ;
         T00016_A27CidNome = new String[] {""} ;
         T00016_n27CidNome = new bool[] {false} ;
         T00016_A26CidCodi = new int[1] ;
         T00016_n26CidCodi = new bool[] {false} ;
         T00016_A24EstCodi = new int[1] ;
         T00016_n24EstCodi = new bool[] {false} ;
         RcdFound1 = 0 ;
         Gx_BScreen = 0 ;
         T00017_A13PesCodi = new int[1] ;
         T00015_A13PesCodi = new int[1] ;
         T00015_A14PesNome = new String[] {""} ;
         T00015_n14PesNome = new bool[] {false} ;
         T00015_A15PesCPF = new String[] {""} ;
         T00015_n15PesCPF = new bool[] {false} ;
         T00015_A16PesDatN = new DateTime[] {DateTime.MinValue} ;
         T00015_n16PesDatN = new bool[] {false} ;
         T00015_A17PesEnde = new String[] {""} ;
         T00015_n17PesEnde = new bool[] {false} ;
         T00015_A18PesEndN = new String[] {""} ;
         T00015_n18PesEndN = new bool[] {false} ;
         T00015_A19PesBair = new String[] {""} ;
         T00015_n19PesBair = new bool[] {false} ;
         T00015_A20PesEmai = new String[] {""} ;
         T00015_n20PesEmai = new bool[] {false} ;
         T00015_A21PesTele = new String[] {""} ;
         T00015_n21PesTele = new bool[] {false} ;
         T00015_A22PesCelu = new String[] {""} ;
         T00015_n22PesCelu = new bool[] {false} ;
         T00015_A23PesSitu = new short[1] ;
         T00015_n23PesSitu = new bool[] {false} ;
         T00015_A26CidCodi = new int[1] ;
         T00015_n26CidCodi = new bool[] {false} ;
         sMode1 = "" ;
         T00018_A13PesCodi = new int[1] ;
         T00019_A13PesCodi = new int[1] ;
         T00014_A13PesCodi = new int[1] ;
         T00014_A14PesNome = new String[] {""} ;
         T00014_n14PesNome = new bool[] {false} ;
         T00014_A15PesCPF = new String[] {""} ;
         T00014_n15PesCPF = new bool[] {false} ;
         T00014_A16PesDatN = new DateTime[] {DateTime.MinValue} ;
         T00014_n16PesDatN = new bool[] {false} ;
         T00014_A17PesEnde = new String[] {""} ;
         T00014_n17PesEnde = new bool[] {false} ;
         T00014_A18PesEndN = new String[] {""} ;
         T00014_n18PesEndN = new bool[] {false} ;
         T00014_A19PesBair = new String[] {""} ;
         T00014_n19PesBair = new bool[] {false} ;
         T00014_A20PesEmai = new String[] {""} ;
         T00014_n20PesEmai = new bool[] {false} ;
         T00014_A21PesTele = new String[] {""} ;
         T00014_n21PesTele = new bool[] {false} ;
         T00014_A22PesCelu = new String[] {""} ;
         T00014_n22PesCelu = new bool[] {false} ;
         T00014_A23PesSitu = new short[1] ;
         T00014_n23PesSitu = new bool[] {false} ;
         T00014_A26CidCodi = new int[1] ;
         T00014_n26CidCodi = new bool[] {false} ;
         Gx_longc = false ;
         T000111_A13PesCodi = new int[1] ;
         T000114_A27CidNome = new String[] {""} ;
         T000114_n27CidNome = new bool[] {false} ;
         T000114_A24EstCodi = new int[1] ;
         T000114_n24EstCodi = new bool[] {false} ;
         T000115_A25EstUF = new String[] {""} ;
         T000115_n25EstUF = new bool[] {false} ;
         T000115_A12EstNome = new String[] {""} ;
         T000115_n12EstNome = new bool[] {false} ;
         T000116_A13PesCodi = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tpessoa__default(),
            new Object[][] {
                new Object[] {
               T00012_A25EstUF, T00012_n25EstUF, T00012_A12EstNome, T00012_n12EstNome
               }
               , new Object[] {
               T00013_A27CidNome, T00013_n27CidNome, T00013_A24EstCodi, T00013_n24EstCodi
               }
               , new Object[] {
               T00014_A13PesCodi, T00014_A14PesNome, T00014_n14PesNome, T00014_A15PesCPF, T00014_n15PesCPF, T00014_A16PesDatN, T00014_n16PesDatN, T00014_A17PesEnde, T00014_n17PesEnde, T00014_A18PesEndN,
               T00014_n18PesEndN, T00014_A19PesBair, T00014_n19PesBair, T00014_A20PesEmai, T00014_n20PesEmai, T00014_A21PesTele, T00014_n21PesTele, T00014_A22PesCelu, T00014_n22PesCelu, T00014_A23PesSitu,
               T00014_n23PesSitu, T00014_A26CidCodi, T00014_n26CidCodi
               }
               , new Object[] {
               T00015_A13PesCodi, T00015_A14PesNome, T00015_n14PesNome, T00015_A15PesCPF, T00015_n15PesCPF, T00015_A16PesDatN, T00015_n16PesDatN, T00015_A17PesEnde, T00015_n17PesEnde, T00015_A18PesEndN,
               T00015_n18PesEndN, T00015_A19PesBair, T00015_n19PesBair, T00015_A20PesEmai, T00015_n20PesEmai, T00015_A21PesTele, T00015_n21PesTele, T00015_A22PesCelu, T00015_n22PesCelu, T00015_A23PesSitu,
               T00015_n23PesSitu, T00015_A26CidCodi, T00015_n26CidCodi
               }
               , new Object[] {
               T00016_A13PesCodi, T00016_A14PesNome, T00016_n14PesNome, T00016_A15PesCPF, T00016_n15PesCPF, T00016_A16PesDatN, T00016_n16PesDatN, T00016_A17PesEnde, T00016_n17PesEnde, T00016_A18PesEndN,
               T00016_n18PesEndN, T00016_A19PesBair, T00016_n19PesBair, T00016_A20PesEmai, T00016_n20PesEmai, T00016_A21PesTele, T00016_n21PesTele, T00016_A22PesCelu, T00016_n22PesCelu, T00016_A23PesSitu,
               T00016_n23PesSitu, T00016_A25EstUF, T00016_n25EstUF, T00016_A12EstNome, T00016_n12EstNome, T00016_A27CidNome, T00016_n27CidNome, T00016_A26CidCodi, T00016_n26CidCodi, T00016_A24EstCodi,
               T00016_n24EstCodi
               }
               , new Object[] {
               T00017_A13PesCodi
               }
               , new Object[] {
               T00018_A13PesCodi
               }
               , new Object[] {
               T00019_A13PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000111_A13PesCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000114_A27CidNome, T000114_n27CidNome, T000114_A24EstCodi, T000114_n24EstCodi
               }
               , new Object[] {
               T000115_A25EstUF, T000115_n25EstUF, T000115_A12EstNome, T000115_n12EstNome
               }
               , new Object[] {
               T000116_A13PesCodi
               }
            }
         );
         reloadDynamicLists(0);
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A23PesSitu ;
      protected short geteqAfterKey= 1 ;
      protected short Z23PesSitu ;
      protected short RcdFound1 ;
      protected short Gx_BScreen ;
      protected int trnEnded ;
      protected int A24EstCodi ;
      protected int A26CidCodi ;
      protected int A13PesCodi ;
      protected int K13PesCodi ;
      protected int lastAnyError ;
      protected int Z26CidCodi ;
      protected int GX_JID ;
      protected int Z13PesCodi ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String A25EstUF ;
      protected String scmdbuf ;
      protected String sMode1 ;
      protected DateTime A16PesDatN ;
      protected DateTime Z16PesDatN ;
      protected bool n14PesNome ;
      protected bool n15PesCPF ;
      protected bool n16PesDatN ;
      protected bool n17PesEnde ;
      protected bool n18PesEndN ;
      protected bool n19PesBair ;
      protected bool n20PesEmai ;
      protected bool n21PesTele ;
      protected bool n22PesCelu ;
      protected bool n23PesSitu ;
      protected bool n24EstCodi ;
      protected bool n25EstUF ;
      protected bool n12EstNome ;
      protected bool n26CidCodi ;
      protected bool n27CidNome ;
      protected bool Gx_longc ;
      protected String A14PesNome ;
      protected String A15PesCPF ;
      protected String A17PesEnde ;
      protected String A18PesEndN ;
      protected String A19PesBair ;
      protected String A20PesEmai ;
      protected String A21PesTele ;
      protected String A22PesCelu ;
      protected String A12EstNome ;
      protected String A27CidNome ;
      protected String Z14PesNome ;
      protected String Z15PesCPF ;
      protected String Z17PesEnde ;
      protected String Z18PesEndN ;
      protected String Z19PesBair ;
      protected String Z20PesEmai ;
      protected String Z21PesTele ;
      protected String Z22PesCelu ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtPesCodigo ;
      protected GUIObjectString edtPesNome ;
      protected GUIObjectString edtPesCPF ;
      protected GUIObjectDatetime edtPesDatNasc ;
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
      protected IGXButton bttBtn_enter ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl12 ;
      protected ILabel lbllbl14 ;
      protected ILabel lbllbl16 ;
      protected ILabel lbllbl18 ;
      protected ILabel lbllbl20 ;
      protected ILabel lbllbl22 ;
      protected ILabel lbllbl24 ;
      protected ILabel lbllbl26 ;
      protected ILabel lbllbl28 ;
      protected ILabel lbllbl30 ;
      protected ILabel lbllbl32 ;
      protected ILabel lbllbl34 ;
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
      protected IDataReader T00015 ;
      protected IDataReader T00016 ;
      protected int[] T00016_A13PesCodi ;
      protected String[] T00016_A14PesNome ;
      protected bool[] T00016_n14PesNome ;
      protected String[] T00016_A15PesCPF ;
      protected bool[] T00016_n15PesCPF ;
      protected DateTime[] T00016_A16PesDatN ;
      protected bool[] T00016_n16PesDatN ;
      protected String[] T00016_A17PesEnde ;
      protected bool[] T00016_n17PesEnde ;
      protected String[] T00016_A18PesEndN ;
      protected bool[] T00016_n18PesEndN ;
      protected String[] T00016_A19PesBair ;
      protected bool[] T00016_n19PesBair ;
      protected String[] T00016_A20PesEmai ;
      protected bool[] T00016_n20PesEmai ;
      protected String[] T00016_A21PesTele ;
      protected bool[] T00016_n21PesTele ;
      protected String[] T00016_A22PesCelu ;
      protected bool[] T00016_n22PesCelu ;
      protected short[] T00016_A23PesSitu ;
      protected bool[] T00016_n23PesSitu ;
      protected String[] T00016_A25EstUF ;
      protected bool[] T00016_n25EstUF ;
      protected String[] T00016_A12EstNome ;
      protected bool[] T00016_n12EstNome ;
      protected String[] T00016_A27CidNome ;
      protected bool[] T00016_n27CidNome ;
      protected int[] T00016_A26CidCodi ;
      protected bool[] T00016_n26CidCodi ;
      protected int[] T00016_A24EstCodi ;
      protected bool[] T00016_n24EstCodi ;
      protected IDataReader T00017 ;
      protected int[] T00017_A13PesCodi ;
      protected int[] T00015_A13PesCodi ;
      protected String[] T00015_A14PesNome ;
      protected bool[] T00015_n14PesNome ;
      protected String[] T00015_A15PesCPF ;
      protected bool[] T00015_n15PesCPF ;
      protected DateTime[] T00015_A16PesDatN ;
      protected bool[] T00015_n16PesDatN ;
      protected String[] T00015_A17PesEnde ;
      protected bool[] T00015_n17PesEnde ;
      protected String[] T00015_A18PesEndN ;
      protected bool[] T00015_n18PesEndN ;
      protected String[] T00015_A19PesBair ;
      protected bool[] T00015_n19PesBair ;
      protected String[] T00015_A20PesEmai ;
      protected bool[] T00015_n20PesEmai ;
      protected String[] T00015_A21PesTele ;
      protected bool[] T00015_n21PesTele ;
      protected String[] T00015_A22PesCelu ;
      protected bool[] T00015_n22PesCelu ;
      protected short[] T00015_A23PesSitu ;
      protected bool[] T00015_n23PesSitu ;
      protected int[] T00015_A26CidCodi ;
      protected bool[] T00015_n26CidCodi ;
      protected IDataReader T00018 ;
      protected int[] T00018_A13PesCodi ;
      protected IDataReader T00019 ;
      protected int[] T00019_A13PesCodi ;
      protected int[] T00014_A13PesCodi ;
      protected String[] T00014_A14PesNome ;
      protected bool[] T00014_n14PesNome ;
      protected String[] T00014_A15PesCPF ;
      protected bool[] T00014_n15PesCPF ;
      protected DateTime[] T00014_A16PesDatN ;
      protected bool[] T00014_n16PesDatN ;
      protected String[] T00014_A17PesEnde ;
      protected bool[] T00014_n17PesEnde ;
      protected String[] T00014_A18PesEndN ;
      protected bool[] T00014_n18PesEndN ;
      protected String[] T00014_A19PesBair ;
      protected bool[] T00014_n19PesBair ;
      protected String[] T00014_A20PesEmai ;
      protected bool[] T00014_n20PesEmai ;
      protected String[] T00014_A21PesTele ;
      protected bool[] T00014_n21PesTele ;
      protected String[] T00014_A22PesCelu ;
      protected bool[] T00014_n22PesCelu ;
      protected short[] T00014_A23PesSitu ;
      protected bool[] T00014_n23PesSitu ;
      protected int[] T00014_A26CidCodi ;
      protected bool[] T00014_n26CidCodi ;
      protected IDataReader T000111 ;
      protected int[] T000111_A13PesCodi ;
      protected IDataReader T000114 ;
      protected String[] T000114_A27CidNome ;
      protected bool[] T000114_n27CidNome ;
      protected int[] T000114_A24EstCodi ;
      protected bool[] T000114_n24EstCodi ;
      protected IDataReader T000115 ;
      protected String[] T000115_A25EstUF ;
      protected bool[] T000115_n25EstUF ;
      protected String[] T000115_A12EstNome ;
      protected bool[] T000115_n12EstNome ;
      protected IDataReader T000116 ;
      protected int[] T000116_A13PesCodi ;
   }

   public class tpessoa__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
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
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@PesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesDatNasc",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesEndereco",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEndNumero",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesBairro",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PesTelefone",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesCelular",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@PesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesCPF",SqlDbType.VarChar,14,0} ,
          new Object[] {"@PesDatNasc",SqlDbType.DateTime,8,0} ,
          new Object[] {"@PesEndereco",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEndNumero",SqlDbType.VarChar,20,0} ,
          new Object[] {"@PesBairro",SqlDbType.VarChar,50,0} ,
          new Object[] {"@PesEmail",SqlDbType.VarChar,100,0} ,
          new Object[] {"@PesTelefone",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesCelular",SqlDbType.VarChar,13,0} ,
          new Object[] {"@PesSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@CidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          new Object[] {"@EstCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T00012", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00013", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00014", "SELECT [PesCodigo], [PesNome], [PesCPF], [PesDatNasc], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [CidCodigo] FROM [PESSOA] WITH (UPDLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00015", "SELECT [PesCodigo], [PesNome], [PesCPF], [PesDatNasc], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [CidCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00016", "SELECT TM1.[PesCodigo], TM1.[PesNome], TM1.[PesCPF], TM1.[PesDatNasc], TM1.[PesEndereco], TM1.[PesEndNumero], TM1.[PesBairro], TM1.[PesEmail], TM1.[PesTelefone], TM1.[PesCelular], TM1.[PesSituacao], T3.[EstUF], T3.[EstNome], T2.[CidNome], TM1.[CidCodigo], T2.[EstCodigo] FROM (([PESSOA] TM1 WITH (NOLOCK) LEFT JOIN [CIDADE] T2 WITH (NOLOCK) ON T2.[CidCodigo] = TM1.[CidCodigo]) LEFT JOIN [ESTADO] T3 WITH (NOLOCK) ON T3.[EstCodigo] = T2.[EstCodigo]) WHERE TM1.[PesCodigo] = @PesCodigo ORDER BY TM1.[PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00017", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00018", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ( [PesCodigo] > @PesCodigo) ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T00019", "SELECT TOP 1 [PesCodigo] FROM [PESSOA] WITH (NOLOCK) WHERE ( [PesCodigo] < @PesCodigo) ORDER BY [PesCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000110", "INSERT INTO [PESSOA] ([PesNome], [PesCPF], [PesDatNasc], [PesEndereco], [PesEndNumero], [PesBairro], [PesEmail], [PesTelefone], [PesCelular], [PesSituacao], [CidCodigo]) VALUES (@PesNome, @PesCPF, @PesDatNasc, @PesEndereco, @PesEndNumero, @PesBairro, @PesEmail, @PesTelefone, @PesCelular, @PesSituacao, @CidCodigo)", GxErrorMask.GX_NOMASK,prmT000110)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000111", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000112", "UPDATE [PESSOA] SET [PesNome]=@PesNome, [PesCPF]=@PesCPF, [PesDatNasc]=@PesDatNasc, [PesEndereco]=@PesEndereco, [PesEndNumero]=@PesEndNumero, [PesBairro]=@PesBairro, [PesEmail]=@PesEmail, [PesTelefone]=@PesTelefone, [PesCelular]=@PesCelular, [PesSituacao]=@PesSituacao, [CidCodigo]=@CidCodigo  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000112)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000113", "DELETE FROM [PESSOA]  WHERE [PesCodigo] = @PesCodigo", GxErrorMask.GX_NOMASK,prmT000113)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000114", "SELECT [CidNome], [EstCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE [CidCodigo] = @CidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000115", "SELECT [EstUF], [EstNome] FROM [ESTADO] WITH (NOLOCK) WHERE [EstCodigo] = @EstCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000116", "SELECT [PesCodigo] FROM [PESSOA] WITH (NOLOCK) ORDER BY [PesCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
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
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((int[]) buf[21])[0] = rslt.getInt(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
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
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((int[]) buf[21])[0] = rslt.getInt(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
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
                ((short[]) buf[19])[0] = rslt.getShort(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getString(12, 2) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((int[]) buf[27])[0] = rslt.getInt(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((int[]) buf[29])[0] = rslt.getInt(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
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
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
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
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(11, (int)parms[21]);
                }
                break;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
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
                   stmt.setNull( 3 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(3, (DateTime)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[7]);
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
                   stmt.setNull( 10 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(10, (short)parms[19]);
                }
                if ( (bool)parms[20] )
                {
                   stmt.setNull( 11 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(11, (int)parms[21]);
                }
                stmt.SetParameter(12, (int)parms[22]);
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
       }
    }

 }

}
