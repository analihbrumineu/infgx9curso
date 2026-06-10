/*
               File: Locacao
        Description: Cadastro de locações.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:12.8
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
   public class tlocacao : GXTransaction
   {
      public tlocacao( int hnd ,
                       ModelContext jContext ) : base(hnd,jContext, "")
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tlocacao( IGxContext context ) : base(-1,null, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public tlocacao( IGxContext context ,
                       int hnd ,
                       ModelContext jContext ) : base(hnd,jContext, "")
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void InitializeNonKey0B12( )
      {
         A95LocTotV = (decimal)(0M) ;
         n95LocTotV = false ;
         A87LocSitu = 1 ;
         n87LocSitu = false ;
         A88LocDatL = Gx_date ;
         n88LocDatL = false ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         n89LocDatD = (((DateTime.MinValue==A89LocDatD)) ? true : false) ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         n90LocDatC = (((DateTime.MinValue==A90LocDatC)) ? true : false) ;
         A91LocCliP = 0 ;
         n91LocCliP = false ;
         n91LocCliP = (((0==A91LocCliP)) ? true : false) ;
         A92LocCliP = "" ;
         n92LocCliP = false ;
         A93LocVenP = AV7Funcion.gxTpr_Pescodigo ;
         n93LocVenP = false ;
         A94LocVenP = AV7Funcion.gxTpr_Pesnome ;
         n94LocVenP = false ;
      }

      protected void InitAll0B12( )
      {
         A86LocCodi = 0 ;
         K86LocCodi = A86LocCodi ;
         geteqAfterKey = 1 ;
         clear( ) ;
         InitializeNonKey0B12( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A87LocSitu = i87LocSitu ;
         cmbLocSituacao.setValue(A87LocSitu);
         n87LocSitu = false ;
         A93LocVenP = i93LocVenP ;
         edtLocVenPesCodigo.setValue(A93LocVenP);
         n93LocVenP = false ;
         A88LocDatL = i88LocDatL ;
         edtLocDatLocacao.setValue(A88LocDatL);
         n88LocDatL = false ;
      }

      protected void InitializeNonKey0B13( )
      {
         A103LocMid = 0 ;
         n103LocMid = false ;
         A104LocMid = "" ;
         n104LocMid = false ;
         A105LocMid = 0 ;
         n105LocMid = false ;
         A118LocMid = "" ;
         n118LocMid = false ;
         A106LocMid = 0 ;
         n106LocMid = false ;
         A108LocMid = 0 ;
         n108LocMid = false ;
         A109LocMid = (decimal)(0M) ;
         n109LocMid = false ;
      }

      protected void InitAll0B13( )
      {
         A102LocMid = 0 ;
         A107LocMid = 0 ;
         n107LocMid = false ;
         K102LocMid = A102LocMid ;
         geteqAfterKey13 = 1 ;
         InitializeNonKey0B13( ) ;
      }

      protected void StandaloneModalInsert0B13( )
      {
      }

      protected void ResetCaption0B0( )
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
         return "Locacao" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de locações." ;
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
         return 806 ;
      }

      public override int getFrmHeight( )
      {
         return 533 ;
      }

      public override String getHelpId( )
      {
         return "HLP_TLocacao.htm";
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

      public void execute( int aP0_LocCodigo ,
                           String aP1_Gx_mode )
      {
         this.AV19LocCod = aP0_LocCodigo;
         this.Gx_mode = aP1_Gx_mode;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 806 , 533 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavLoctotvalor = new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),91, 496, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 91 , 496 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV20LocTot" );
         ((GXEdit) edtavLoctotvalor.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavLoctotvalor.addFocusListener(this);
         edtavLoctotvalor.getGXComponent().setHelpId("HLP_TLocacao.htm");
         bttEnter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  689 ,  494 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttEnter.setTooltip("Confirmar");
         bttEnter.addActionListener(this);
         lbllbl36 = UIFactory.getLabel(GXPanel1, "Total", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 500 , 30 , 13 );
         tctrlCadastrodelocacao = new GXTabControl (this,  GXPanel1 , 0 , 0 , 806 , 482 , UIFactory.getColor(5) , UIFactory.getColor(8) , 0, 0, 0, false );
         tpagetpage3 = new GXTabPage ( tctrlCadastrodelocacao , "Dados da locação" , 5 , 29 , 801 , 453 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         edtLocCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),182, 78, 91, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 78 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A86LocCodi" );
         ((GXEdit) edtLocCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtLocCodigo.addFocusListener(this);
         edtLocCodigo.getGXComponent().setHelpId("HLP_TLocacao.htm");
         cmbLocSituacao = new GUIObjectShort ( new GXComboBox(tpagetpage3.getGXPanel()) , tpagetpage3.getGXPanel() , 182 , 104 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A87LocSitu" );
         ((GXComboBox) cmbLocSituacao.getGXComponent()).addItem( new java.lang.Short(1),"Digitada");
         ((GXComboBox) cmbLocSituacao.getGXComponent()).addItem( new java.lang.Short(2),"Realizada");
         ((GXComboBox) cmbLocSituacao.getGXComponent()).addItem( new java.lang.Short(3),"Devolvida");
         ((GXComboBox) cmbLocSituacao.getGXComponent()).addItem( new java.lang.Short(4),"Cancelada");
         cmbLocSituacao.addFocusListener(this);
         cmbLocSituacao.addItemListener(this);
         cmbLocSituacao.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocDatLocacao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),182, 130, 91, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 130 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A88LocDatL" );
         ((GXEdit) edtLocDatLocacao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtLocDatLocacao.addFocusListener(this);
         edtLocDatLocacao.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocDatDevolucao = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),182, 156, 91, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 156 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A89LocDatD" );
         ((GXEdit) edtLocDatDevolucao.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtLocDatDevolucao.addFocusListener(this);
         edtLocDatDevolucao.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocDatCancelamento = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),182, 182, 91, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 182 , 91 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A90LocDatC" );
         ((GXEdit) edtLocDatCancelamento.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtLocDatCancelamento.addFocusListener(this);
         edtLocDatCancelamento.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocCliPesCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),182, 273, 73, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , tpagetpage3.getGXPanel() , 182 , 273 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "A91LocCliP" );
         ((GXEdit) edtLocCliPesCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtLocCliPesCodigo.addFocusListener(this);
         edtLocCliPesCodigo.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocCliPesNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),182, 297, 360, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 297 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A92LocCliP" );
         ((GXEdit) edtLocCliPesNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtLocCliPesNome.addFocusListener(this);
         edtLocCliPesNome.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocVenPesCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),182, 377, 73, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 377 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A93LocVenP" );
         ((GXEdit) edtLocVenPesCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtLocVenPesCodigo.addFocusListener(this);
         edtLocVenPesCodigo.getGXComponent().setHelpId("HLP_TLocacao.htm");
         edtLocVenPesNome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),182, 401, 360, 21, tpagetpage3.getGXPanel(), false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), true) , tpagetpage3.getGXPanel() , 182 , 401 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A94LocVenP" );
         ((GXEdit) edtLocVenPesNome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtLocVenPesNome.addFocusListener(this);
         edtLocVenPesNome.getGXComponent().setHelpId("HLP_TLocacao.htm");
         lbllbl16 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Cadastro de locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 118 , 13 );
         lbllbl5 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 82 , 40 , 13 );
         lbllbl7 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Situação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 108 , 51 , 13 );
         lbllbl9 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Data da locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 134 , 95 , 13 );
         lbllbl11 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Data da devolução", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 160 , 109 , 13 );
         lbllbl13 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Data de cancelamento", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 186 , 129 , 13 );
         lbllbl22 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Área do cliente", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 247 , 87 , 13 );
         lbllbl18 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 277 , 40 , 13 );
         lbllbl20 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Nome completo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 301 , 88 , 13 );
         lbllbl27 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Área do vendedor", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 351 , 102 , 13 );
         lbllbl24 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 381 , 40 , 13 );
         lbllbl25 = UIFactory.getLabel(tpagetpage3.getGXPanel(), "Nome completo", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 52 , 405 , 88 , 13 );
         rctrct26 = UIFactory.getGXRectangle( tpagetpage3.getGXPanel() , 1 , 39 , 364 , 508 , 79 , Integer.MAX_VALUE , UIFactory.getColor(0) , ILabelConstants.BORDER_SINGLE );
         rctrct23 = UIFactory.getGXRectangle( tpagetpage3.getGXPanel() , 1 , 65 , 221 , 456 , 1 , UIFactory.getColor(5) , UIFactory.getColor(6) , ILabelConstants.BORDER_NONE );
         rctrct21 = UIFactory.getGXRectangle( tpagetpage3.getGXPanel() , 1 , 39 , 260 , 508 , 79 , Integer.MAX_VALUE , UIFactory.getColor(0) , ILabelConstants.BORDER_SINGLE );
         tpagetpage28 = new GXTabPage ( tctrlCadastrodelocacao , "Seleção de mídias" , 5 , 29 , 801 , 453 , UIFactory.getColor(15) , UIFactory.getColor(18) , 0, 0);
         addSubfile ( subGrd  = new GXSubfileTRN ( new Locacao_flow30(this) , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 53, 19, tpagetpage28.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 52 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , true , "A102LocMid" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 52 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 377, 19, tpagetpage28.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 376 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A104LocMid" ), "Título"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 376 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(tpagetpage28.getGXPanel(), false) , null ,  0 , 0 , 129 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A106LocMid" ), "Formato"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 129 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 112, 19, tpagetpage28.getGXPanel(), false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 111 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A109LocMid" ), "Valor (em R$)"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 111 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 19 , 18 , tpagetpage28.getGXPanel() , 39 , 78 , 728 , 364 ,  18 ));
         ((GXComboBox) subGrd.getColumn(2).getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) subGrd.getColumn(2).getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) subGrd.getColumn(2).getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) subGrd.getColumn(2).getGXComponent()).addItem( new java.lang.Short(4),"Box");
         subGrd.addActionListener(this);
         subGrd.addFocusListener(this);
         subGrd.setSortOnClick(false);
         lbllbl29 = UIFactory.getLabel(tpagetpage28.getGXPanel(), "Seleção de mídias", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 39 , 26 , 106 , 13 );
         subGrd.getColumn(0).addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         edtLocCliPesCodigo.addContextAction(this, "BROWSE", GXResourceManager.GetMessage("toolbrowsedata"));
         focusManager.setControlList(new IFocusableControl[] {
                   edtLocCodigo ,
                   cmbLocSituacao ,
                   edtLocDatLocacao ,
                   edtLocDatDevolucao ,
                   edtLocDatCancelamento ,
                   edtLocCliPesCodigo ,
                   edtLocCliPesNome ,
                   edtLocVenPesCodigo ,
                   edtLocVenPesNome ,
                   subGrd ,
                   edtavLoctotvalor ,
                   bttEnter
         });
      }

      public override void setFocusFirst( )
      {
         Valid_Loccodigo();
         setFocus(edtLocCliPesCodigo, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void clear( )
      {
         InitializeNonKey0B12( ) ;
         subGrd.startLoad();
         subtlocacao30 = new subtlocacao30 ();
         subGrd.endLoad();
      }

      protected void disable_std_buttons( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 ) )
         {
            bttEnter.setGXEnabled(0);
            edtLocCodigo.setEnabled(0);
            cmbLocSituacao.setEnabled(0);
            edtLocDatLocacao.setEnabled(0);
            edtLocDatDevolucao.setEnabled(0);
            edtLocDatCancelamento.setEnabled(0);
            edtLocVenPesCodigo.setEnabled(0);
            edtLocVenPesNome.setEnabled(0);
            edtLocCliPesCodigo.setEnabled(0);
            edtLocCliPesNome.setEnabled(0);
            subGrd.getColumn(0).setEnabled(0);
            subGrd.getColumn(1).setEnabled(0);
            subGrd.getColumn(2).setEnabled(0);
            subGrd.getColumn(3).setEnabled(0);
            edtavLoctotvalor.setEnabled(0);
            setFocus(bttEnter, true);
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
            bttEnter.setCaption(GXResourceManager.GetMessage("captionconfirm"));
            bttEnter.setTooltip(GXResourceManager.GetMessage("captionconfirm"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
         {
            bttEnter.setCaption(GXResourceManager.GetMessage("captionadd"));
            bttEnter.setTooltip(GXResourceManager.GetMessage("captionadd"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
         {
            bttEnter.setCaption(GXResourceManager.GetMessage("captionupdate"));
            bttEnter.setTooltip(GXResourceManager.GetMessage("captionupdate"));
         }
         else if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            bttEnter.setCaption(GXResourceManager.GetMessage("captiondelete"));
            bttEnter.setTooltip(GXResourceManager.GetMessage("captiondelete"));
         }
         else
         {
         }
      }

      protected void AfterTrn( )
      {
         if ( ( trnEnded == 1 ) )
         {
            /* Execute user event: E110B2 */
            E110B2 ();
            trnEnded = 0 ;
            if (!cleanedUp) {
               standaloneNotModal( ) ;
               standaloneModal( ) ;
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  )
               {
                  /* Clear variables for new insertion. */
                  InitAll0B12( ) ;
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

      public void loadToBuffer30( )
      {
         subtlocacao30 oAux = subtlocacao30 ;
         subtlocacao30 = new subtlocacao30 ();
         variablesToSubfile30 ();
         subGrd.addElement(subtlocacao30);
         subtlocacao30 = oAux;
      }

      public bool isLoadAtStartup_flow30( )
      {
         return false;
      }

      public void autoRefresh_flow30( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
      }

      public bool getSearch_flow30( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow30( )
      {
      }

      public void resetSearchConditions_flow30( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow30( )
      {
         if ( subGrd.getItemCount() > 0 )
         {
            subtlocacao30 = ( subtlocacao30 ) subGrd.getElementAt(subGrd.getItemCount() -1);
            subfileToVariables30 ();
            /* Save values for previous() function. */
         }
         subtlocacao30 = new subtlocacao30 ();
         InitAll0B13( ) ;
         sMode13 = Gx_mode ;
         Gx_mode = "INS" ;
         standaloneModal0B13( ) ;
         Gx_mode = sMode13 ;
         variablesToSubfile30 ();
         return subtlocacao30 ;
      }

      public bool getSearch_flow30( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow30( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow30( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         String Gx_mode = element.getMode();
         subtlocacao30 subtlocacao30  = ( subtlocacao30 ) element;
         if ( col == 0 )
         {
            return ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  );
         }
         return !enabled;
      }

      public void refresh_flow30( )
      {
      }

      public class Locacao_flow30 : GXSubfileFlow
      {
         tlocacao _sf ;

         public Locacao_flow30( tlocacao uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow30();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow30(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow30();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow30();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow30(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow30();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow30(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow30(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow30(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow30();
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
         /* Execute user event: E120B2 */
         E120B2 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         lastAnyError = AnyError ;
         AnyError = 0;
         if ( bttEnter.isEventSource(eventSource) ) {
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
         if ( subGrd.isEventSource(eventSource) ) {
            GXEnter( );
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtLocCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtLocCodigo.getGXCursor() );
            return;
         }
         if ( cmbLocSituacao.isEventSource(eventSource) ) {
            setGXCursor( cmbLocSituacao.getGXCursor() );
            return;
         }
         if ( edtLocDatLocacao.isEventSource(eventSource) ) {
            setGXCursor( edtLocDatLocacao.getGXCursor() );
            return;
         }
         if ( edtLocDatDevolucao.isEventSource(eventSource) ) {
            setGXCursor( edtLocDatDevolucao.getGXCursor() );
            return;
         }
         if ( edtLocDatCancelamento.isEventSource(eventSource) ) {
            setGXCursor( edtLocDatCancelamento.getGXCursor() );
            return;
         }
         if ( edtLocVenPesCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtLocVenPesCodigo.getGXCursor() );
            return;
         }
         if ( edtLocVenPesNome.isEventSource(eventSource) ) {
            setGXCursor( edtLocVenPesNome.getGXCursor() );
            return;
         }
         if ( edtLocCliPesCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtLocCliPesCodigo.getGXCursor() );
            return;
         }
         if ( edtLocCliPesNome.isEventSource(eventSource) ) {
            setGXCursor( edtLocCliPesNome.getGXCursor() );
            return;
         }
         if ( edtavLoctotvalor.isEventSource(eventSource) ) {
            setGXCursor( edtavLoctotvalor.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
         AnyError = 0 ;
         if ( edtavLoctotvalor.isEventSource(eventSource) ) {
            Validv_Loctotvalor ();
            return;
         }
         if ( edtLocCliPesCodigo.isEventSource(eventSource) ) {
            Valid_Locclipescodigo ();
            return;
         }
         if ( subGrd.getColumn(3).isEventSource(eventSource) ) {
            subtlocacao30 = (subtlocacao30)subGrd.cloneCurrentElement();
            if ( ( subtlocacao30.isDeleted() != 1 ) )
            {
               subfileToVariables30 ();
               sMode13 = Gx_mode ;
               Gx_mode = (String)(subtlocacao30.getTrnMode()) ;
               Valid_Locmidmidconfvalor ();
               Gx_mode = sMode13 ;
            }
            return;
         }
         if ( edtLocCodigo.isEventSource(eventSource) ) {
            Valid_Loccodigo ();
            return;
         }
         if ( edtLocVenPesCodigo.isEventSource(eventSource) ) {
            Valid_Locvenpescodigo ();
            return;
         }
         if ( edtLocVenPesNome.isEventSource(eventSource) ) {
            Valid_Locvenpesnome ();
            return;
         }
         if ( subGrd.getColumn(0).isEventSource(eventSource) ) {
            subtlocacao30 = (subtlocacao30)subGrd.cloneCurrentElement();
            if ( ( subtlocacao30.isDeleted() != 1 ) )
            {
               subfileToVariables30 ();
               sMode13 = Gx_mode ;
               Gx_mode = (String)(subtlocacao30.getTrnMode()) ;
               Valid_Locmidmidcodigo ();
               Gx_mode = sMode13 ;
            }
            return;
         }
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtLocCodigo.isEventSource(eventSource) ) {
            A86LocCodi = edtLocCodigo.getValue() ;
            return;
         }
         if ( cmbLocSituacao.isEventSource(eventSource) ) {
            A87LocSitu = cmbLocSituacao.getValue() ;
            n87LocSitu = (((0==A87LocSitu)) ? true : false) ;
            return;
         }
         if ( edtLocDatLocacao.isEventSource(eventSource) ) {
            A88LocDatL = edtLocDatLocacao.getValue() ;
            n88LocDatL = (((DateTime.MinValue==A88LocDatL)) ? true : false) ;
            return;
         }
         if ( edtLocDatDevolucao.isEventSource(eventSource) ) {
            A89LocDatD = edtLocDatDevolucao.getValue() ;
            n89LocDatD = (((DateTime.MinValue==A89LocDatD)) ? true : false) ;
            return;
         }
         if ( edtLocDatCancelamento.isEventSource(eventSource) ) {
            A90LocDatC = edtLocDatCancelamento.getValue() ;
            n90LocDatC = (((DateTime.MinValue==A90LocDatC)) ? true : false) ;
            return;
         }
         if ( edtLocVenPesCodigo.isEventSource(eventSource) ) {
            A93LocVenP = edtLocVenPesCodigo.getValue() ;
            n93LocVenP = (((0==A93LocVenP)) ? true : false) ;
            return;
         }
         if ( edtLocVenPesNome.isEventSource(eventSource) ) {
            A94LocVenP = edtLocVenPesNome.getValue() ;
            n94LocVenP = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A94LocVenP).TrimEnd(' ') )==0)) ? true : false) ;
            return;
         }
         if ( edtLocCliPesCodigo.isEventSource(eventSource) ) {
            A91LocCliP = edtLocCliPesCodigo.getValue() ;
            n91LocCliP = (((0==A91LocCliP)) ? true : false) ;
            return;
         }
         if ( edtLocCliPesNome.isEventSource(eventSource) ) {
            A92LocCliP = edtLocCliPesNome.getValue() ;
            return;
         }
         if ( edtavLoctotvalor.isEventSource(eventSource) ) {
            AV20LocTot = edtavLoctotvalor.getValue() ;
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
            /* Execute user event: E130B2 */
            E130B2 ();
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
         if ( ( edtLocCodigo.isEventSource(eventSource) ) && ( ( A86LocCodi != edtLocCodigo.getValue() ) ) )
         {
            return true;
         }
         return false;
      }

      public override bool isBodyControl( Object eventSource )
      {
         if ( ( cmbLocSituacao.isEventSource(eventSource) ) && ( ( A87LocSitu != cmbLocSituacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtLocDatLocacao.isEventSource(eventSource) ) && ( ( A88LocDatL != edtLocDatLocacao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtLocDatDevolucao.isEventSource(eventSource) ) && ( ( A89LocDatD != edtLocDatDevolucao.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtLocDatCancelamento.isEventSource(eventSource) ) && ( ( A90LocDatC != edtLocDatCancelamento.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtLocVenPesCodigo.isEventSource(eventSource) ) && ( ( A93LocVenP != edtLocVenPesCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtLocVenPesNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A94LocVenP.TrimEnd(' '), edtLocVenPesNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if ( ( edtLocCliPesCodigo.isEventSource(eventSource) ) && ( ( A91LocCliP != edtLocCliPesCodigo.getValue() ) ) )
         {
            return true;
         }
         if ( ( edtLocCliPesNome.isEventSource(eventSource) ) && ( ( String.CompareOrdinal(A92LocCliP.TrimEnd(' '), edtLocCliPesNome.getValue().TrimEnd(' ') ) != 0 ) ) )
         {
            return true;
         }
         if (subGrd.elementsEventSource(eventSource))
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
         ResetCaption0B0( ) ;
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
         return bttEnter ;
      }

      public bool promptHandler( Object eventSource )
      {
         if (( subGrd.getColumn(0).isEventSource(eventSource) ) && ( subGrd.getColumn(0).isEnabled() )) {
            eventLevelContext( );
            prompt_102_13( ) ;
            eventLevelResetContext( );
            return true ;
         }
         if (( edtLocCliPesCodigo.isEventSource(eventSource) ) && ( edtLocCliPesCodigo.isEnabled() )) {
            prompt_91_12( ) ;
            return true ;
         }
         return false;
      }

      public override void deleteLineHandler( Object eventSource ,
                                              int row )
      {
         if ( subGrd .isEventSource(eventSource)) {
            if ( row < 0 ) {
               subtlocacao30 = ( subtlocacao30 ) subGrd.getCurrentElement() ;
            }
            else
            {
               subtlocacao30 = ( subtlocacao30 ) subGrd.getElementAt(row) ;
            }
            subfileToVariables30 ();
            if ( ( subtlocacao30.isDeleted() == 1 ) )
            {
               sMode13 = Gx_mode ;
               Gx_mode = "DLT" ;
            }
            else
            {
               sMode13 = Gx_mode ;
               Gx_mode = "INS" ;
            }
            validate_on_delete13 ();
            Gx_mode = sMode13 ;
         }
      }

      public override void setNoAccept( Object eventSource )
      {
         if ( edtLocCliPesCodigo.isEventSource(eventSource) )
         {
            edtLocCliPesCodigo.setEnabled(!( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 )  || ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DSP".TrimEnd(' ') ) == 0 )  ));
         }
      }

      protected void variablesToSubfile30( )
      {
         subtlocacao30.setLocMidMidCodigo(A102LocMid);
         subtlocacao30.setLocMidFilCodigo(A103LocMid);
         subtlocacao30.setLocMidFilNome(A104LocMid);
         subtlocacao30.setLocMidCatCodigo(A105LocMid);
         subtlocacao30.setLocMidCatNome(A118LocMid);
         subtlocacao30.setLocMidMidTipo(A106LocMid);
         subtlocacao30.setLocMidMidSituacao(A107LocMid);
         subtlocacao30.setLocMidMidLocCodigo(A108LocMid);
         subtlocacao30.setLocMidMidConfValor(A109LocMid);
         subtlocacao30.setZLocMidFilCodigo(Z103LocMid);
         subtlocacao30.setZLocMidFilNome(Z104LocMid);
         subtlocacao30.setZLocMidMidTipo(Z106LocMid);
         subtlocacao30.setZLocMidMidLocCodigo(Z108LocMid);
         subtlocacao30.setZLocMidMidConfValor(Z109LocMid);
         subtlocacao30.setZLocMidCatCodigo(Z105LocMid);
      }

      protected void subfileToVariables30( )
      {
         A102LocMid = subtlocacao30.getLocMidMidCodigo();
         A103LocMid = subtlocacao30.getLocMidFilCodigo();
         A104LocMid = subtlocacao30.getLocMidFilNome();
         n104LocMid = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A104LocMid).TrimEnd(' ') )==0)) ? true : false) ;
         A105LocMid = subtlocacao30.getLocMidCatCodigo();
         A118LocMid = subtlocacao30.getLocMidCatNome();
         A106LocMid = subtlocacao30.getLocMidMidTipo();
         n106LocMid = (((0==A106LocMid)) ? true : false) ;
         A107LocMid = subtlocacao30.getLocMidMidSituacao();
         A108LocMid = subtlocacao30.getLocMidMidLocCodigo();
         A109LocMid = subtlocacao30.getLocMidMidConfValor();
         n109LocMid = (((Convert.ToDecimal(0M)==A109LocMid)) ? true : false) ;
         Z103LocMid = subtlocacao30.getZLocMidFilCodigo();
         Z104LocMid = subtlocacao30.getZLocMidFilNome();
         Z106LocMid = subtlocacao30.getZLocMidMidTipo();
         Z108LocMid = subtlocacao30.getZLocMidMidLocCodigo();
         Z109LocMid = subtlocacao30.getZLocMidMidConfValor();
         Z105LocMid = subtlocacao30.getZLocMidCatCodigo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtLocCodigo.setValue( A86LocCodi );
         cmbLocSituacao.setValue( A87LocSitu );
         edtLocDatLocacao.setValue( A88LocDatL );
         edtLocDatDevolucao.setValue( A89LocDatD );
         edtLocDatCancelamento.setValue( A90LocDatC );
         edtLocVenPesCodigo.setValue( A93LocVenP );
         edtLocVenPesNome.setValue( A94LocVenP );
         edtLocCliPesCodigo.setValue( A91LocCliP );
         edtLocCliPesNome.setValue( A92LocCliP );
         edtavLoctotvalor.setValue( AV20LocTot );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A86LocCodi = (int)(edtLocCodigo.getValue()) ;
         edtLocCodigo.setValue(A86LocCodi);
         A87LocSitu = (short)(cmbLocSituacao.getValue()) ;
         cmbLocSituacao.setValue(A87LocSitu);
         n87LocSitu = false ;
         n87LocSitu = (((0==A87LocSitu)) ? true : false) ;
         A88LocDatL = (DateTime)(edtLocDatLocacao.getValue()) ;
         edtLocDatLocacao.setValue(A88LocDatL);
         n88LocDatL = false ;
         n88LocDatL = (((DateTime.MinValue==A88LocDatL)) ? true : false) ;
         A89LocDatD = (DateTime)(edtLocDatDevolucao.getValue()) ;
         edtLocDatDevolucao.setValue(A89LocDatD);
         n89LocDatD = false ;
         n89LocDatD = (((DateTime.MinValue==A89LocDatD)) ? true : false) ;
         A90LocDatC = (DateTime)(edtLocDatCancelamento.getValue()) ;
         edtLocDatCancelamento.setValue(A90LocDatC);
         n90LocDatC = false ;
         n90LocDatC = (((DateTime.MinValue==A90LocDatC)) ? true : false) ;
         A93LocVenP = (int)(edtLocVenPesCodigo.getValue()) ;
         edtLocVenPesCodigo.setValue(A93LocVenP);
         n93LocVenP = false ;
         n93LocVenP = (((0==A93LocVenP)) ? true : false) ;
         A94LocVenP = (String)(edtLocVenPesNome.getValue()) ;
         edtLocVenPesNome.setValue(A94LocVenP);
         n94LocVenP = false ;
         n94LocVenP = (((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A94LocVenP).TrimEnd(' ') )==0)) ? true : false) ;
         A91LocCliP = (int)(edtLocCliPesCodigo.getValue()) ;
         edtLocCliPesCodigo.setValue(A91LocCliP);
         n91LocCliP = false ;
         n91LocCliP = (((0==A91LocCliP)) ? true : false) ;
         A92LocCliP = (String)(edtLocCliPesNome.getValue()) ;
         edtLocCliPesNome.setValue(A92LocCliP);
         n92LocCliP = false ;
         AV20LocTot = (decimal)(edtavLoctotvalor.getValue()) ;
         edtavLoctotvalor.setValue(AV20LocTot);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGrd.inValidElement() )
         {
            subtlocacao30 = ( subtlocacao30 ) subGrd.getCurrentElement() ;
         }
         else
         {
            subtlocacao30 = new subtlocacao30 ();
         }
         subfileToVariables30 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile30 ();
         subGrd.refreshLineValue(subtlocacao30);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd.inValidElement() )
         {
            subtlocacao30 = ( subtlocacao30 ) subGrd.getCurrentElement() ;
         }
         else
         {
            subtlocacao30 = new subtlocacao30 ();
         }
         subfileToVariables30 ();
      }

      protected void prompt_91_12( )
      {
         new wgx0010(context, base.remoteHandle, base.context).execute( out  A91LocCliP) ;
         edtLocCliPesCodigo.setValue( A91LocCliP );
         n91LocCliP = false ;
         setFocus(edtLocCliPesCodigo);
         ResetCaption0B0( ) ;
      }

      protected void prompt_102_13( )
      {
         new wgx0090(context, base.remoteHandle, base.context).execute( out  A102LocMid) ;
         ((subtlocacao30)subGrd.getCurrentElement()).setLocMidMidCodigo(A102LocMid);
         subGrd.refreshLineValue(subGrd.getSelectedElement());
         subGrd.repaint();
         ResetCaption0B0( ) ;
      }

      protected void Valid_Loccodigo( )
      {
         if ( ( A86LocCodi != K86LocCodi ) || ( geteqAfterKey == 1 ) )
         {
            if ( ( AnyError == 0 ) )
            {
               K86LocCodi = A86LocCodi ;
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

      protected void Valid_Locclipescodigo( )
      {
         /* Using cursor T000B2 */
         pr_default.execute(0, new Object[] {n91LocCliP, A91LocCliP});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A91LocCliP)) ) )
            {
               GXutil.msg( me(), "Não existe 'Cliente da locação.'." );
               AnyError = 1 ;
               setNextFocus( edtLocCliPesCodigo );
               setFocusNext();
            }
         }
         A92LocCliP = T000B2_A92LocCliP[0] ;
         n92LocCliP = T000B2_n92LocCliP[0] ;
         pr_default.close(0);
         edtLocCliPesNome.setValue( A92LocCliP );
         pr_default.close(0);
      }

      protected void Valid_Locvenpescodigo( )
      {
      }

      protected void Valid_Locvenpesnome( )
      {
      }

      protected void Validv_Loctotvalor( )
      {
         reloadGridRow();
      }

      protected void Valid_Locmidmidcodigo( )
      {
         if ( ( A102LocMid != K102LocMid ) || ( geteqAfterKey13 == 1 ) )
         {
            /* Using cursor T000B3 */
            pr_default.execute(1, new Object[] {A102LocMid});
            if ( (pr_default.getStatus(1) == 101) )
            {
               GXutil.msg( me(), "Não existe 'Loc Mid Mid Loc Codigo'." );
               AnyError = 1 ;
               subGrd.cancelSubfileMove();
            }
            A107LocMid = T000B3_A107LocMid[0] ;
            n107LocMid = T000B3_n107LocMid[0] ;
            pr_default.close(1);
            ((subtlocacao30)subGrd.getCurrentElement()).setLocMidMidSituacao(A107LocMid);
            subGrd.refreshLineValue(subGrd.getSelectedElement());
            subGrd.repaint();
            pr_default.close(1);
            if ( ( AnyError == 0 ) )
            {
               geteqAfterKey13 = 0 ;
            }
            else
            {
               geteqAfterKey13 = 1 ;
            }
         }
      }

      protected void Valid_Locmidmidconfvalor( )
      {
         reloadGridRow();
      }

      protected void validate_on_delete13( )
      {
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000B3 */
            pr_default.execute(1, new Object[] {A102LocMid});
            A107LocMid = T000B3_A107LocMid[0] ;
            n107LocMid = T000B3_n107LocMid[0] ;
            pr_default.close(1);
         }
      }

      protected void E120B2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         tctrlCadastrodelocacao.setActivePage(1);
         AV20LocTot = A95LocTotV ;
         edtavLoctotvalor.setValue(AV20LocTot);
      }

      protected void E130B2( )
      {
         eventLevelContext();
         /* 'Pesquisar' Routine */
         if ( GXCursor("A91LocCliP") )
         {
            GXt_svchar1 = "Locacao" ;
            new wconscliente(context, base.remoteHandle, base.context).execute( ref  GXt_svchar1, out  A91LocCliP) ;
            edtLocCliPesCodigo.setValue( A91LocCliP );
            n91LocCliP = false ;
         }
         else if ( GXCursor("A102LocMid") )
         {
            new wconsmidia(context, base.remoteHandle, base.context).execute( out  A102LocMid, out  A103LocMid, out  A104LocMid, out  A105LocMid, out  A106LocMid, out  A109LocMid) ;
            ((subtlocacao30)subGrd.getCurrentElement()).setLocMidMidCodigo(A102LocMid);
            subGrd.refreshLineValue(subGrd.getSelectedElement());
            subGrd.repaint();
            ((subtlocacao30)subGrd.getCurrentElement()).setLocMidFilNome(A104LocMid);
            subGrd.refreshLineValue(subGrd.getSelectedElement());
            subGrd.repaint();
            n104LocMid = false ;
            ((subtlocacao30)subGrd.getCurrentElement()).setLocMidMidTipo(A106LocMid);
            subGrd.refreshLineValue(subGrd.getSelectedElement());
            subGrd.repaint();
            n106LocMid = false ;
            ((subtlocacao30)subGrd.getCurrentElement()).setLocMidMidConfValor(A109LocMid);
            subGrd.refreshLineValue(subGrd.getSelectedElement());
            subGrd.repaint();
            n109LocMid = false ;
            AV20LocTot = (decimal)(AV20LocTot+A109LocMid) ;
            edtavLoctotvalor.setValue(AV20LocTot);
         }
         eventLevelResetContext();
      }

      protected void E110B2( )
      {
         /* After Trn Routine */
         com.genexus.GXutil.confirm( me(), "Deseja realizar esta locação?" , true );
         AV18Y = 0 ;
         if ( GXutil.Confirmed )
         {
            AV18Y = 1 ;
            new patzlocacao(context, base.remoteHandle, base.context).execute(  AV18Y, ref  A86LocCodi,  AV14AtzLoc, ref  A87LocSitu, out  AV25MsgErr) ;
            edtLocCodigo.setValue( A86LocCodi );
            cmbLocSituacao.setValue( A87LocSitu );
            n87LocSitu = false ;
         }
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
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
               sMode12 = Gx_mode ;
               Gx_mode = "UPD" ;
               Gx_mode = sMode12 ;
            }
            standaloneModal( ) ;
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               getByPrimaryKey( ) ;
               if ( ( RcdFound12 != 1 ) )
               {
                  pushError( GXResourceManager.GetMessage("noinsert") );
                  AnyError = 1 ;
                  keepFocus();
               }
            }
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               i87LocSitu = A87LocSitu ;
               i93LocVenP = A93LocVenP ;
               i88LocDatL = A88LocDatL ;
            }
         }
         set_caption( ) ;
         PreviousCaption = bttEnter.getCaption() ;
      }

      protected void ZM0B12( int GX_JID )
      {
         if ( ( GX_JID == 22 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z95LocTotV = T000B8_A95LocTotV[0] ;
               Z87LocSitu = T000B8_A87LocSitu[0] ;
               Z88LocDatL = T000B8_A88LocDatL[0] ;
               Z89LocDatD = T000B8_A89LocDatD[0] ;
               Z90LocDatC = T000B8_A90LocDatC[0] ;
               Z91LocCliP = T000B8_A91LocCliP[0] ;
               Z93LocVenP = T000B8_A93LocVenP[0] ;
            }
            else
            {
               Z95LocTotV = A95LocTotV ;
               Z87LocSitu = A87LocSitu ;
               Z88LocDatL = A88LocDatL ;
               Z89LocDatD = A89LocDatD ;
               Z90LocDatC = A90LocDatC ;
               Z91LocCliP = A91LocCliP ;
               Z93LocVenP = A93LocVenP ;
            }
         }
         if ( ( GX_JID == 24 ) || ( GX_JID == 0 ) )
         {
            Z94LocVenP = T000B10_A94LocVenP[0] ;
         }
         if ( ( GX_JID == -22 ) )
         {
            Z86LocCodi = A86LocCodi ;
            Z95LocTotV = A95LocTotV ;
            Z87LocSitu = A87LocSitu ;
            Z88LocDatL = A88LocDatL ;
            Z89LocDatD = A89LocDatD ;
            Z90LocDatC = A90LocDatC ;
            Z91LocCliP = A91LocCliP ;
            Z93LocVenP = A93LocVenP ;
            Z94LocVenP = A94LocVenP ;
         }
      }

      public override void standaloneNotModal( )
      {
         edtLocCodigo.setEnabled(0);
         cmbLocSituacao.setEnabled(0);
         edtLocVenPesCodigo.setEnabled(0);
         edtLocVenPesNome.setEnabled(0);
         edtLocDatLocacao.setEnabled(0);
         edtLocDatDevolucao.setEnabled(0);
         edtLocDatCancelamento.setEnabled(0);
         Gx_date = DateTimeUtil.Today( ) ;
         Gx_BScreen = 0 ;
         new pretfunlogdados(context, base.remoteHandle, base.context).execute( out  AV7Funcion) ;
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            A86LocCodi = AV19LocCod ;
            edtLocCodigo.setValue(A86LocCodi);
         }
      }

      public override void standaloneModal( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((0==A87LocSitu)) && ( Gx_BScreen == 0 ) )
         {
            A87LocSitu = 1 ;
            cmbLocSituacao.setValue(A87LocSitu);
            n87LocSitu = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((0==A93LocVenP)) && ( Gx_BScreen == 0 ) )
         {
            A93LocVenP = AV7Funcion.gxTpr_Pescodigo ;
            edtLocVenPesCodigo.setValue(A93LocVenP);
            n93LocVenP = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((DateTime.MinValue==A88LocDatL)) && ( Gx_BScreen == 0 ) )
         {
            A88LocDatL = Gx_date ;
            edtLocDatLocacao.setValue(A88LocDatL);
            n88LocDatL = false ;
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000B10 */
            pr_default.execute(8, new Object[] {n93LocVenP, A93LocVenP});
            ZM0B12( 24) ;
            A94LocVenP = T000B10_A94LocVenP[0] ;
            n94LocVenP = T000B10_n94LocVenP[0] ;
            pr_default.close(8);
         }
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subGrd.setEnabled(0);
         }
      }

      protected void Load0B12( )
      {
         /* Using cursor T000B11 */
         pr_default.execute(9, new Object[] {A86LocCodi});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound12 = 1 ;
            A95LocTotV = T000B11_A95LocTotV[0] ;
            n95LocTotV = T000B11_n95LocTotV[0] ;
            A87LocSitu = T000B11_A87LocSitu[0] ;
            n87LocSitu = T000B11_n87LocSitu[0] ;
            A88LocDatL = T000B11_A88LocDatL[0] ;
            n88LocDatL = T000B11_n88LocDatL[0] ;
            A89LocDatD = T000B11_A89LocDatD[0] ;
            n89LocDatD = T000B11_n89LocDatD[0] ;
            A90LocDatC = T000B11_A90LocDatC[0] ;
            n90LocDatC = T000B11_n90LocDatC[0] ;
            A92LocCliP = T000B11_A92LocCliP[0] ;
            n92LocCliP = T000B11_n92LocCliP[0] ;
            A94LocVenP = T000B11_A94LocVenP[0] ;
            n94LocVenP = T000B11_n94LocVenP[0] ;
            A91LocCliP = T000B11_A91LocCliP[0] ;
            n91LocCliP = T000B11_n91LocCliP[0] ;
            A93LocVenP = T000B11_A93LocVenP[0] ;
            n93LocVenP = T000B11_n93LocVenP[0] ;
            ZM0B12( -22) ;
         }
         pr_default.close(9);
         OnLoadActions0B12( ) ;
      }

      protected void OnLoadActions0B12( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A94LocVenP).TrimEnd(' ') )==0)) && ( Gx_BScreen == 0 ) )
         {
            A94LocVenP = AV7Funcion.gxTpr_Pesnome ;
            edtLocVenPesNome.setValue(A94LocVenP);
            n94LocVenP = false ;
         }
      }

      protected void CheckExtendedTable0B12( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T000B2 */
         pr_default.execute(0, new Object[] {n91LocCliP, A91LocCliP});
         if ( (pr_default.getStatus(0) == 101) )
         {
            if ( ! ( ((0==A91LocCliP)) ) )
            {
               pushError( "Não existe 'Cliente da locação.'." );
               AnyError = 1 ;
               setNextFocus( edtLocCliPesCodigo );
            }
         }
         A92LocCliP = T000B2_A92LocCliP[0] ;
         n92LocCliP = T000B2_n92LocCliP[0] ;
         pr_default.close(0);
         /* Using cursor T000B10 */
         pr_default.execute(8, new Object[] {n93LocVenP, A93LocVenP});
         if ( (pr_default.getStatus(8) == 101) )
         {
            if ( ! ( ((0==A93LocVenP)) ) )
            {
               pushError( "Não existe 'Vendedor da locação.'." );
               AnyError = 1 ;
               setNextFocus( edtLocVenPesCodigo );
            }
         }
         A94LocVenP = T000B10_A94LocVenP[0] ;
         n94LocVenP = T000B10_n94LocVenP[0] ;
         pr_default.close(8);
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A94LocVenP).TrimEnd(' ') )==0)) && ( Gx_BScreen == 0 ) )
         {
            A94LocVenP = AV7Funcion.gxTpr_Pesnome ;
            edtLocVenPesNome.setValue(A94LocVenP);
            n94LocVenP = false ;
         }
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors0B12( )
      {
         pr_default.close(0);
         pr_default.close(8);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0B12( )
      {
         /* Using cursor T000B12 */
         pr_default.execute(10, new Object[] {A86LocCodi});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound12 = 1 ;
         }
         else
         {
            RcdFound12 = 0 ;
         }
         pr_default.close(10);
      }

      public override void getByPrimaryKey( )
      {
         /* Using cursor T000B8 */
         pr_default.execute(6, new Object[] {A86LocCodi});
         if ( (pr_default.getStatus(6) != 101) )
         {
            ZM0B12( 22) ;
            RcdFound12 = 1 ;
            A86LocCodi = T000B8_A86LocCodi[0] ;
            A95LocTotV = T000B8_A95LocTotV[0] ;
            n95LocTotV = T000B8_n95LocTotV[0] ;
            A87LocSitu = T000B8_A87LocSitu[0] ;
            n87LocSitu = T000B8_n87LocSitu[0] ;
            A88LocDatL = T000B8_A88LocDatL[0] ;
            n88LocDatL = T000B8_n88LocDatL[0] ;
            A89LocDatD = T000B8_A89LocDatD[0] ;
            n89LocDatD = T000B8_n89LocDatD[0] ;
            A90LocDatC = T000B8_A90LocDatC[0] ;
            n90LocDatC = T000B8_n90LocDatC[0] ;
            A91LocCliP = T000B8_A91LocCliP[0] ;
            n91LocCliP = T000B8_n91LocCliP[0] ;
            A93LocVenP = T000B8_A93LocVenP[0] ;
            n93LocVenP = T000B8_n93LocVenP[0] ;
            Z86LocCodi = A86LocCodi ;
            sMode12 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load0B12( ) ;
            Gx_mode = sMode12 ;
         }
         else
         {
            RcdFound12 = 0 ;
            InitializeNonKey0B12( ) ;
            sMode12 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode12 ;
         }
         K86LocCodi = A86LocCodi ;
         pr_default.close(6);
         subGrd.startLoad();
         subtlocacao30 = new subtlocacao30 ();
         if ( ( RcdFound12 == 1 ) )
         {
            ScanStart0B13( ) ;
            while ( ( RcdFound13 != 0 ) )
            {
               getByPrimaryKey0B13( ) ;
               AddRow0B13( ) ;
               ScanNext0B13( ) ;
            }
            ScanEnd0B13( ) ;
         }
         subGrd.endLoad(new subtlocacao30());
      }

      public override void getEqualNoModal( )
      {
         GetKey0B12( ) ;
         if ( ( RcdFound12 == 0 ) )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound12 = 0 ;
         /* Using cursor T000B13 */
         pr_default.execute(11, new Object[] {A86LocCodi});
         if ( (pr_default.getStatus(11) != 101) )
         {
            while ( (pr_default.getStatus(11) != 101) && ( ( T000B13_A86LocCodi[0] < A86LocCodi ) ) )
            {
               pr_default.readNext(11);
            }
            if ( (pr_default.getStatus(11) != 101) && ( ( T000B13_A86LocCodi[0] > A86LocCodi ) ) )
            {
               A86LocCodi = T000B13_A86LocCodi[0] ;
               RcdFound12 = 1 ;
            }
         }
         pr_default.close(11);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0 ;
         /* Using cursor T000B14 */
         pr_default.execute(12, new Object[] {A86LocCodi});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( T000B14_A86LocCodi[0] > A86LocCodi ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( T000B14_A86LocCodi[0] < A86LocCodi ) ) )
            {
               A86LocCodi = T000B14_A86LocCodi[0] ;
               RcdFound12 = 1 ;
            }
         }
         pr_default.close(12);
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
         GetKey0B12( ) ;
         if ( ( RcdFound12 == 1 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 ) )
            {
               pushError( GXResourceManager.GetMessage("noupdate") );
               AnyError = 1 ;
               setNextFocus( edtLocCodigo );
            }
            else if ( ( A86LocCodi != Z86LocCodi ) )
            {
               A86LocCodi = Z86LocCodi ;
               edtLocCodigo.setValue(A86LocCodi);
               pushError( GXResourceManager.GetMessage("getbeforeupd") );
               AnyError = 1 ;
               setNextFocus( edtLocCodigo );
            }
            else
            {
               /* Update record */
               Update0B12( ) ;
               setNextFocus( edtLocCodigo );
            }
         }
         else
         {
            if ( ( A86LocCodi != Z86LocCodi ) )
            {
               /* Insert record */
               Insert0B12( ) ;
               setNextFocus( edtLocCodigo );
            }
            else
            {
               if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "UPD".TrimEnd(' ') ) == 0 ) )
               {
                  pushError( GXResourceManager.GetMessage("recdeleted") );
                  AnyError = 1 ;
                  setNextFocus( edtLocCodigo );
               }
               else
               {
                  /* Insert record */
                  Insert0B12( ) ;
                  setNextFocus( edtLocCodigo );
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
         if ( ( A86LocCodi != Z86LocCodi ) )
         {
            A86LocCodi = Z86LocCodi ;
            edtLocCodigo.setValue(A86LocCodi);
            pushError( GXResourceManager.GetMessage("getbeforedlt") );
            AnyError = 1 ;
            setNextFocus( edtLocCodigo );
         }
         else
         {
            delete( ) ;
            handleErrors();
            AfterTrn( ) ;
            setNextFocus( edtLocCodigo );
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

      protected void CheckOptimisticConcurrency0B12( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T000B7 */
            pr_default.execute(5, new Object[] {A86LocCodi});
            if ( ! (pr_default.getStatus(5) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"LOCACAO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(5) == 101) || ( Z95LocTotV != T000B7_A95LocTotV[0] ) || ( Z87LocSitu != T000B7_A87LocSitu[0] ) || ( Z88LocDatL != T000B7_A88LocDatL[0] ) || ( Z89LocDatD != T000B7_A89LocDatD[0] ) || ( Z90LocDatC != T000B7_A90LocDatC[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z91LocCliP != T000B7_A91LocCliP[0] ) || ( Z93LocVenP != T000B7_A93LocVenP[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"LOCACAO"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
         /* Using cursor T000B9 */
         pr_default.execute(7, new Object[] {n93LocVenP, A93LocVenP});
         if ( ! (pr_default.getStatus(7) != 103) )
         {
            pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"PESSOA"})) );
            AnyError = 1 ;
            keepFocus();
            return  ;
         }
         if ( false || ( String.CompareOrdinal(Z94LocVenP.TrimEnd(' '), T000B9_A94LocVenP[0].TrimEnd(' ') ) != 0 ) )
         {
            pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"PESSOA"})) );
            AnyError = 1 ;
            keepFocus();
            return  ;
         }
      }

      protected void Insert0B12( )
      {
         BeforeValidate0B12( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0B12( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM0B12( 0) ;
            CheckOptimisticConcurrency0B12( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0B12( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert0B12( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000B15 */
                     pr_default.execute(13, new Object[] {n95LocTotV, A95LocTotV, n87LocSitu, A87LocSitu, n88LocDatL, A88LocDatL, n89LocDatD, A89LocDatD, n90LocDatC, A90LocDatC, n91LocCliP, A91LocCliP, n93LocVenP, A93LocVenP});
                     pr_default.close(13);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000B16 */
                     pr_default.execute(14);
                     A86LocCodi = T000B16_A86LocCodi[0] ;
                     pr_default.close(14);
                     if ( ( AnyError == 0 ) )
                     {
                        UpdateTablesN10B12( ) ;
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           ProcessLevel0B12( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              /* Save values for previous() function. */
                              base.context.msgStatus(GXResourceManager.GetMessage("sucadded"));
                              ResetCaption0B0( ) ;
                              subGrd.startLoad();
                              subtlocacao30 = new subtlocacao30 ();
                              subGrd.endLoad();
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
               Load0B12( ) ;
            }
            EndLevel0B12( ) ;
         }
         CloseExtendedTableCursors0B12( ) ;
      }

      protected void Update0B12( )
      {
         BeforeValidate0B12( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0B12( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0B12( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0B12( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate0B12( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000B17 */
                     pr_default.execute(15, new Object[] {n95LocTotV, A95LocTotV, n87LocSitu, A87LocSitu, n88LocDatL, A88LocDatL, n89LocDatD, A89LocDatD, n90LocDatC, A90LocDatC, n91LocCliP, A91LocCliP, n93LocVenP, A93LocVenP, A86LocCodi});
                     pr_default.close(15);
                     DeferredUpdate0B12( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        UpdateTablesN10B12( ) ;
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           ProcessLevel0B12( ) ;
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
            EndLevel0B12( ) ;
         }
         CloseExtendedTableCursors0B12( ) ;
      }

      protected void DeferredUpdate0B12( )
      {
      }

      public override void delete( )
      {
         BeforeValidate0B12( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0B12( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls0B12( ) ;
            ScanStart0B13( ) ;
            while ( ( RcdFound13 != 0 ) )
            {
               getByPrimaryKey0B13( ) ;
               Delete0B13( ) ;
               ScanNext0B13( ) ;
            }
            ScanEnd0B13( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0B12( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeDelete0B12( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000B18 */
                     pr_default.execute(16, new Object[] {A86LocCodi});
                     pr_default.close(16);
                     if ( ( AnyError == 0 ) )
                     {
                        UpdateTablesN10B12( ) ;
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
         sMode12 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel0B12( ) ;
         Gx_mode = sMode12 ;
      }

      protected void OnDeleteControls0B12( )
      {
         standaloneModal( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000B19 */
            pr_default.execute(17, new Object[] {n91LocCliP, A91LocCliP});
            A92LocCliP = T000B19_A92LocCliP[0] ;
            n92LocCliP = T000B19_n92LocCliP[0] ;
            pr_default.close(17);
            /* Using cursor T000B20 */
            pr_default.execute(18, new Object[] {n93LocVenP, A93LocVenP});
            Z94LocVenP = T000B20_A94LocVenP[0] ;
            A94LocVenP = T000B20_A94LocVenP[0] ;
            n94LocVenP = T000B20_n94LocVenP[0] ;
            pr_default.close(18);
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) == 0 )  && ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A94LocVenP).TrimEnd(' ') )==0)) && ( Gx_BScreen == 0 ) )
            {
               A94LocVenP = AV7Funcion.gxTpr_Pesnome ;
               edtLocVenPesNome.setValue(A94LocVenP);
               n94LocVenP = false ;
            }
         }
         if ( ( AnyError == 0 ) )
         {
            /* Using cursor T000B21 */
            pr_default.execute(19, new Object[] {A86LocCodi});
            if ( (pr_default.getStatus(19) != 101) )
            {
               pushError( GXResourceManager.GetMessage("del", new   object[]  {"Cadastro de mídias."}) );
               AnyError = 1 ;
               keepFocus();
            }
            pr_default.close(19);
         }
      }

      protected void ProcessNestedLevel0B13( )
      {
         nGXsfl_30_idx = 0 ;
         while ( ( nGXsfl_30_idx < subGrd.getItemCount() ) )
         {
            ReadRow0B13( ) ;
            if ( ( subtlocacao30.isLoaded() != 0 ) || ( subtlocacao30.isChanged() != 0 ) )
            {
               standaloneNotModal0B13( ) ;
               GetKey0B13( ) ;
               if ( ( subtlocacao30.isLoaded() == 0 ) && ( subtlocacao30.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound13 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     Insert0B13( ) ;
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtLocCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound13 != 0 ) )
                  {
                     if ( ( subtlocacao30.isDeleted() != 0 ) && ( subtlocacao30.isLoaded() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        Delete0B13( ) ;
                     }
                     else
                     {
                        if ( ( subtlocacao30.isChanged() != 0 ) && ( subtlocacao30.isLoaded() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           Update0B13( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtlocacao30.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtLocCodigo );
                     }
                  }
               }
            }
         }
         subGrd.endLoad(new subtlocacao30());
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ProcessLevel0B12( )
      {
         /* Save parent mode. */
         sMode12 = Gx_mode ;
         ProcessNestedLevel0B13( ) ;
         if ( ( AnyError != 0 ) )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode12 ;
         /* ' Update level parameters */
      }

      protected void UpdateTablesN10B12( )
      {
         /* Using cursor T000B22 */
         pr_default.execute(20, new Object[] {n94LocVenP, A94LocVenP, n93LocVenP, A93LocVenP});
         pr_default.close(20);
      }

      protected void EndLevel0B12( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(5);
         }
         pr_default.close(7);
         if ( ( AnyError == 0 ) )
         {
            BeforeComplete0B12( ) ;
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            pr_default.close(6);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(1);
            pr_default.close(4);
            context.CommitDataStores("TLocacao");
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(6);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(17);
            pr_default.close(18);
            pr_default.close(1);
            pr_default.close(4);
            context.RollbackDataStores("TLocacao");
            nGXsfl_30_idx = 0 ;
            while ( ( nGXsfl_30_idx < subGrd.getItemCount() ) )
            {
               ReadRow0B13( ) ;
               /* Using cursor T000B5 */
               pr_default.execute(3, new Object[] {A86LocCodi, A102LocMid});
               if ( (pr_default.getStatus(3) != 101) )
               {
                  if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
                  {
                     Z103LocMid = T000B5_A103LocMid[0] ;
                     Z104LocMid = T000B5_A104LocMid[0] ;
                     Z106LocMid = T000B5_A106LocMid[0] ;
                     Z108LocMid = T000B5_A108LocMid[0] ;
                     Z109LocMid = T000B5_A109LocMid[0] ;
                     Z105LocMid = T000B5_A105LocMid[0] ;
                  }
                  else
                  {
                     Z103LocMid = A103LocMid ;
                     Z104LocMid = A104LocMid ;
                     Z106LocMid = A106LocMid ;
                     Z108LocMid = A108LocMid ;
                     Z109LocMid = A109LocMid ;
                     Z105LocMid = A105LocMid ;
                  }
                  variablesToSubfile30 ();
               }
               pr_default.close(3);
            }
         }
         IsModified = 0 ;
      }

      protected void ScanStart0B12( )
      {
         /* Using cursor T000B23 */
         pr_default.execute(21);
         RcdFound12 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound12 = 1 ;
            A86LocCodi = T000B23_A86LocCodi[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B12( )
      {
         pr_default.readNext(21);
         RcdFound12 = 0 ;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound12 = 1 ;
            A86LocCodi = T000B23_A86LocCodi[0] ;
         }
      }

      protected void ScanEnd0B12( )
      {
         pr_default.close(21);
      }

      protected void AfterConfirm0B12( )
      {
         /* After Confirm Rules */
         A95LocTotV = AV20LocTot ;
         n95LocTotV = false ;
      }

      protected void BeforeInsert0B12( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B12( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B12( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B12( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B12( )
      {
         /* Before Validate Rules */
         if ( ( A91LocCliP == 0 ) )
         {
            pushError( "Um cliente deve ser informado!" );
            AnyError = 1 ;
            keepFocus();
         }
         if ( ( AV20LocTot == Convert.ToDecimal( 0 )) || ((Convert.ToDecimal(0M)==AV20LocTot)) )
         {
            pushError( "Pelo menos uma mídia deve ser adicionada!" );
            AnyError = 1 ;
            keepFocus();
         }
      }

      protected void ZM0B13( int GX_JID )
      {
         if ( ( GX_JID == 25 ) || ( GX_JID == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
            {
               Z103LocMid = T000B5_A103LocMid[0] ;
               Z104LocMid = T000B5_A104LocMid[0] ;
               Z106LocMid = T000B5_A106LocMid[0] ;
               Z108LocMid = T000B5_A108LocMid[0] ;
               Z109LocMid = T000B5_A109LocMid[0] ;
               Z105LocMid = T000B5_A105LocMid[0] ;
            }
            else
            {
               Z103LocMid = A103LocMid ;
               Z104LocMid = A104LocMid ;
               Z106LocMid = A106LocMid ;
               Z108LocMid = A108LocMid ;
               Z109LocMid = A109LocMid ;
               Z105LocMid = A105LocMid ;
            }
         }
         if ( ( GX_JID == -25 ) )
         {
            Z86LocCodi = A86LocCodi ;
            Z103LocMid = A103LocMid ;
            Z104LocMid = A104LocMid ;
            Z106LocMid = A106LocMid ;
            Z108LocMid = A108LocMid ;
            Z109LocMid = A109LocMid ;
            Z102LocMid = A102LocMid ;
            Z105LocMid = A105LocMid ;
         }
      }

      protected void standaloneNotModal0B13( )
      {
         subGrd.getColumn(2).setEnabled(0);
         subGrd.getColumn(3).setEnabled(0);
         subGrd.getColumn(1).setEnabled(0);
      }

      protected void standaloneModal0B13( )
      {
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {n105LocMid, A105LocMid});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( ((0==A105LocMid)) ) )
            {
               pushError( "Não existe 'Loc Mid Cat Codigo'." );
               AnyError = 1 ;
            }
         }
         A118LocMid = T000B6_A118LocMid[0] ;
         n118LocMid = T000B6_n118LocMid[0] ;
         pr_default.close(4);
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
         {
            subGrd.setEnabled(0);
         }
      }

      protected void Load0B13( )
      {
         /* Using cursor T000B24 */
         pr_default.execute(22, new Object[] {A86LocCodi, A102LocMid});
         if ( (pr_default.getStatus(22) != 101) )
         {
            RcdFound13 = 1 ;
            A103LocMid = T000B24_A103LocMid[0] ;
            n103LocMid = T000B24_n103LocMid[0] ;
            A104LocMid = T000B24_A104LocMid[0] ;
            n104LocMid = T000B24_n104LocMid[0] ;
            A118LocMid = T000B24_A118LocMid[0] ;
            n118LocMid = T000B24_n118LocMid[0] ;
            A106LocMid = T000B24_A106LocMid[0] ;
            n106LocMid = T000B24_n106LocMid[0] ;
            A107LocMid = T000B24_A107LocMid[0] ;
            n107LocMid = T000B24_n107LocMid[0] ;
            A108LocMid = T000B24_A108LocMid[0] ;
            n108LocMid = T000B24_n108LocMid[0] ;
            A109LocMid = T000B24_A109LocMid[0] ;
            n109LocMid = T000B24_n109LocMid[0] ;
            A105LocMid = T000B24_A105LocMid[0] ;
            n105LocMid = T000B24_n105LocMid[0] ;
            ZM0B13( -25) ;
         }
         pr_default.close(22);
         OnLoadActions0B13( ) ;
      }

      protected void OnLoadActions0B13( )
      {
      }

      protected void CheckExtendedTable0B13( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0B13( ) ;
         Gx_BScreen = 0 ;
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A102LocMid});
         if ( (pr_default.getStatus(1) == 101) )
         {
            pushError( "Não existe 'Loc Mid Mid Loc Codigo'." );
            AnyError = 1 ;
            setNextFocus( new GXSubfileCell(subGrd, nGXsfl_30_idx - 1, 0) );
         }
         A107LocMid = T000B3_A107LocMid[0] ;
         n107LocMid = T000B3_n107LocMid[0] ;
         pr_default.close(1);
         Gx_BScreen = 1 ;
      }

      protected void CloseExtendedTableCursors0B13( )
      {
         pr_default.close(1);
      }

      protected void enableDisable0B13( )
      {
      }

      protected void GetKey0B13( )
      {
         /* Using cursor T000B25 */
         pr_default.execute(23, new Object[] {A86LocCodi, A102LocMid});
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound13 = 1 ;
         }
         else
         {
            RcdFound13 = 0 ;
         }
         pr_default.close(23);
      }

      protected void getByPrimaryKey0B13( )
      {
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {A86LocCodi, A102LocMid});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0B13( 25) ;
            RcdFound13 = 1 ;
            InitializeNonKey0B13( ) ;
            A103LocMid = T000B5_A103LocMid[0] ;
            n103LocMid = T000B5_n103LocMid[0] ;
            A104LocMid = T000B5_A104LocMid[0] ;
            n104LocMid = T000B5_n104LocMid[0] ;
            A106LocMid = T000B5_A106LocMid[0] ;
            n106LocMid = T000B5_n106LocMid[0] ;
            A108LocMid = T000B5_A108LocMid[0] ;
            n108LocMid = T000B5_n108LocMid[0] ;
            A109LocMid = T000B5_A109LocMid[0] ;
            n109LocMid = T000B5_n109LocMid[0] ;
            A102LocMid = T000B5_A102LocMid[0] ;
            A105LocMid = T000B5_A105LocMid[0] ;
            n105LocMid = T000B5_n105LocMid[0] ;
            Z86LocCodi = A86LocCodi ;
            Z102LocMid = A102LocMid ;
            sMode13 = Gx_mode ;
            Gx_mode = "DSP" ;
            Load0B13( ) ;
            Gx_mode = sMode13 ;
         }
         else
         {
            RcdFound13 = 0 ;
            InitializeNonKey0B13( ) ;
            sMode13 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal0B13( ) ;
            Gx_mode = sMode13 ;
         }
         K102LocMid = A102LocMid ;
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency0B13( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            /* Using cursor T000B4 */
            pr_default.execute(2, new Object[] {A86LocCodi, A102LocMid});
            if ( ! (pr_default.getStatus(2) != 103) )
            {
               pushError( (String)(GXResourceManager.GetMessage("lock", new   object[]  {"LOCACAOLOCACAOMIDIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(2) == 101) || ( Z103LocMid != T000B4_A103LocMid[0] ) || ( String.CompareOrdinal(Z104LocMid.TrimEnd(' '), T000B4_A104LocMid[0].TrimEnd(' ') ) != 0 ) || ( Z106LocMid != T000B4_A106LocMid[0] ) || ( Z108LocMid != T000B4_A108LocMid[0] ) || ( Z109LocMid != T000B4_A109LocMid[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z105LocMid != T000B4_A105LocMid[0] ) )
            {
               pushError( (String)(GXResourceManager.GetMessage("waschg", new   object[]  {"LOCACAOLOCACAOMIDIA"})) );
               AnyError = 1 ;
               keepFocus();
               return  ;
            }
         }
      }

      protected void Insert0B13( )
      {
         BeforeValidate0B13( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0B13( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            ZM0B13( 0) ;
            CheckOptimisticConcurrency0B13( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0B13( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeInsert0B13( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000B26 */
                     pr_default.execute(24, new Object[] {A86LocCodi, n103LocMid, A103LocMid, n104LocMid, A104LocMid, n106LocMid, A106LocMid, n108LocMid, A108LocMid, n109LocMid, A109LocMid, A102LocMid, n105LocMid, A105LocMid});
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
               Load0B13( ) ;
            }
            EndLevel0B13( ) ;
         }
         CloseExtendedTableCursors0B13( ) ;
      }

      protected void Update0B13( )
      {
         BeforeValidate0B13( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckExtendedTable0B13( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0B13( ) ;
            if ( ( AnyError == 0 ) )
            {
               AfterConfirm0B13( ) ;
               if ( ( AnyError == 0 ) )
               {
                  BeforeUpdate0B13( ) ;
                  if ( ( AnyError == 0 ) )
                  {
                     /* Using cursor T000B27 */
                     pr_default.execute(25, new Object[] {n103LocMid, A103LocMid, n104LocMid, A104LocMid, n106LocMid, A106LocMid, n108LocMid, A108LocMid, n109LocMid, A109LocMid, n105LocMid, A105LocMid, A86LocCodi, A102LocMid});
                     pr_default.close(25);
                     DeferredUpdate0B13( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( ( AnyError == 0 ) )
                        {
                           getByPrimaryKey0B13( ) ;
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
            EndLevel0B13( ) ;
         }
         CloseExtendedTableCursors0B13( ) ;
      }

      protected void DeferredUpdate0B13( )
      {
      }

      protected void Delete0B13( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate0B13( ) ;
         if ( ( AnyError == 0 ) )
         {
            CheckOptimisticConcurrency0B13( ) ;
         }
         if ( ( AnyError == 0 ) )
         {
            OnDeleteControls0B13( ) ;
            /* No cascading delete specified. */
            AfterConfirm0B13( ) ;
            if ( ( AnyError == 0 ) )
            {
               BeforeDelete0B13( ) ;
               if ( ( AnyError == 0 ) )
               {
                  /* Using cursor T000B28 */
                  pr_default.execute(26, new Object[] {A86LocCodi, A102LocMid});
                  pr_default.close(26);
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
         sMode13 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel0B13( ) ;
         Gx_mode = sMode13 ;
      }

      protected void OnDeleteControls0B13( )
      {
         standaloneModal0B13( ) ;
         if ( ( AnyError == 0 ) )
         {
            /* Delete mode formulas */
            /* Using cursor T000B29 */
            pr_default.execute(27, new Object[] {A102LocMid});
            A107LocMid = T000B29_A107LocMid[0] ;
            n107LocMid = T000B29_n107LocMid[0] ;
            pr_default.close(27);
         }
      }

      protected void EndLevel0B13( )
      {
         if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "INS".TrimEnd(' ') ) != 0 ) )
         {
            pr_default.close(2);
         }
      }

      protected void ScanStart0B13( )
      {
         /* Using cursor T000B30 */
         pr_default.execute(28, new Object[] {A86LocCodi});
         RcdFound13 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound13 = 1 ;
            A102LocMid = T000B30_A102LocMid[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B13( )
      {
         pr_default.readNext(28);
         RcdFound13 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound13 = 1 ;
            A102LocMid = T000B30_A102LocMid[0] ;
         }
      }

      protected void ScanEnd0B13( )
      {
         pr_default.close(28);
      }

      protected void AfterConfirm0B13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B13( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0B13( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0B13( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B13( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B13( )
      {
         /* Before Validate Rules */
      }

      protected void AddRow0B13( )
      {
         loadToBuffer30();
      }

      protected void ReadRow0B13( )
      {
         subtlocacao30 = ( subtlocacao30 ) subGrd.getElementAt(nGXsfl_30_idx) ;
         subfileToVariables30 ();
         nGXsfl_30_idx = (short)(nGXsfl_30_idx+1) ;
      }

      protected void CONFIRM_0B0( )
      {
         BeforeValidate0B12( ) ;
         if ( ( AnyError == 0 ) )
         {
            if ( ( String.CompareOrdinal(Gx_mode.TrimEnd(' '), "DLT".TrimEnd(' ') ) == 0 ) )
            {
               OnDeleteControls0B12( ) ;
            }
            else
            {
               CheckExtendedTable0B12( ) ;
               CloseExtendedTableCursors0B12( ) ;
            }
         }
         if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
         {
            /* Save parent mode. */
            sMode12 = Gx_mode ;
            CONFIRM_0B13( ) ;
            if ( ( AnyError == 0 ) )
            {
               /* Restore parent mode. */
               Gx_mode = sMode12 ;
               PreviousCaption = bttEnter.getCaption() ;
               PreviousTooltip = bttEnter.getTooltip() ;
               IsConfirmed = 1 ;
            }
            /* Restore parent mode. */
            Gx_mode = sMode12 ;
         }
      }

      protected void CONFIRM_0B13( )
      {
         nGXsfl_30_idx = 0 ;
         while ( ( nGXsfl_30_idx < subGrd.getItemCount() ) )
         {
            ReadRow0B13( ) ;
            if ( ( subtlocacao30.isLoaded() != 0 ) || ( subtlocacao30.isChanged() != 0 ) )
            {
               GetKey0B13( ) ;
               if ( ( subtlocacao30.isLoaded() == 0 ) && ( subtlocacao30.isDeleted() == 0 ) )
               {
                  if ( ( RcdFound13 == 0 ) )
                  {
                     Gx_mode = "INS" ;
                     BeforeValidate0B13( ) ;
                     if ( ( AnyError == 0 ) )
                     {
                        CheckExtendedTable0B13( ) ;
                        CloseExtendedTableCursors0B13( ) ;
                        if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                        {
                           PreviousCaption = bttEnter.getCaption() ;
                           PreviousTooltip = bttEnter.getTooltip() ;
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     pushError( GXResourceManager.GetMessage("noupdate") );
                     AnyError = 1 ;
                     setNextFocus( edtLocCodigo );
                  }
               }
               else
               {
                  if ( ( RcdFound13 != 0 ) )
                  {
                     if ( ( subtlocacao30.isDeleted() != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        getByPrimaryKey0B13( ) ;
                        Load0B13( ) ;
                        BeforeValidate0B13( ) ;
                        if ( ( AnyError == 0 ) )
                        {
                           OnDeleteControls0B13( ) ;
                        }
                     }
                     else
                     {
                        if ( ( subtlocacao30.isChanged() != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           BeforeValidate0B13( ) ;
                           if ( ( AnyError == 0 ) )
                           {
                              CheckExtendedTable0B13( ) ;
                              CloseExtendedTableCursors0B13( ) ;
                              if ( ( AnyError == 0 ) && ( sanomodError == 0 ) )
                              {
                                 PreviousCaption = bttEnter.getCaption() ;
                                 PreviousTooltip = bttEnter.getTooltip() ;
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( ( subtlocacao30.isDeleted() == 0 ) )
                     {
                        pushError( GXResourceManager.GetMessage("recdeleted") );
                        AnyError = 1 ;
                        setNextFocus( edtLocCodigo );
                     }
                  }
               }
            }
         }
         subGrd.endLoad();
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
         pr_default.close(3);
         pr_default.close(27);
         pr_default.close(6);
         pr_default.close(17);
         pr_default.close(18);
      }

      public override void initialize( )
      {
         IsConfirmed = 0 ;
         IsModified = 0 ;
         trnEnded = 0 ;
         nKeyPressed = 0 ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         A95LocTotV = (decimal)(0M) ;
         n95LocTotV = false ;
         A87LocSitu = 0 ;
         n87LocSitu = false ;
         A88LocDatL = (DateTime)(DateTime.MinValue) ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         n88LocDatL = false ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         A91LocCliP = 0 ;
         n91LocCliP = false ;
         A92LocCliP = "" ;
         n92LocCliP = false ;
         A93LocVenP = 0 ;
         AV7Funcion = new SdtSDTFuncionario(context);
         n93LocVenP = false ;
         A94LocVenP = "" ;
         n94LocVenP = false ;
         A86LocCodi = 0 ;
         K86LocCodi = 0 ;
         i87LocSitu = 0 ;
         i93LocVenP = 0 ;
         i88LocDatL = (DateTime)(DateTime.MinValue) ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         A104LocMid = "" ;
         n104LocMid = false ;
         A105LocMid = 0 ;
         n105LocMid = false ;
         A118LocMid = "" ;
         n118LocMid = false ;
         A106LocMid = 0 ;
         n106LocMid = false ;
         A108LocMid = 0 ;
         n108LocMid = false ;
         A109LocMid = (decimal)(0M) ;
         n109LocMid = false ;
         A102LocMid = 0 ;
         A107LocMid = 0 ;
         n107LocMid = false ;
         K102LocMid = 0 ;
         subtlocacao30 = new subtlocacao30();
         sMode13 = "" ;
         lastAnyError = 0 ;
         AV20LocTot = (decimal)(0M) ;
         Z103LocMid = 0 ;
         Z104LocMid = "" ;
         Z106LocMid = 0 ;
         Z108LocMid = 0 ;
         Z109LocMid = (decimal)(0M) ;
         Z105LocMid = 0 ;
         scmdbuf = "" ;
         T000B2_A92LocCliP = new String[] {""} ;
         T000B2_n92LocCliP = new bool[] {false} ;
         T000B3_A107LocMid = new short[1] ;
         T000B3_n107LocMid = new bool[] {false} ;
         GXt_svchar1 = "" ;
         AV18Y = 0 ;
         AV14AtzLoc = 0 ;
         AV25MsgErr = "" ;
         returnInSub = false ;
         sMode12 = "" ;
         RcdFound12 = 0 ;
         Z95LocTotV = (decimal)(0M) ;
         Z87LocSitu = 0 ;
         Z88LocDatL = (DateTime)(DateTime.MinValue) ;
         Z89LocDatD = (DateTime)(DateTime.MinValue) ;
         Z90LocDatC = (DateTime)(DateTime.MinValue) ;
         Z91LocCliP = 0 ;
         Z93LocVenP = 0 ;
         Z94LocVenP = "" ;
         GX_JID = 0 ;
         Z86LocCodi = 0 ;
         Gx_BScreen = 0 ;
         T000B10_A94LocVenP = new String[] {""} ;
         T000B10_n94LocVenP = new bool[] {false} ;
         T000B11_A86LocCodi = new int[1] ;
         T000B11_A95LocTotV = new decimal[1] ;
         T000B11_n95LocTotV = new bool[] {false} ;
         T000B11_A87LocSitu = new short[1] ;
         T000B11_n87LocSitu = new bool[] {false} ;
         T000B11_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         T000B11_n88LocDatL = new bool[] {false} ;
         T000B11_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         T000B11_n89LocDatD = new bool[] {false} ;
         T000B11_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         T000B11_n90LocDatC = new bool[] {false} ;
         T000B11_A92LocCliP = new String[] {""} ;
         T000B11_n92LocCliP = new bool[] {false} ;
         T000B11_A94LocVenP = new String[] {""} ;
         T000B11_n94LocVenP = new bool[] {false} ;
         T000B11_A91LocCliP = new int[1] ;
         T000B11_n91LocCliP = new bool[] {false} ;
         T000B11_A93LocVenP = new int[1] ;
         T000B11_n93LocVenP = new bool[] {false} ;
         T000B12_A86LocCodi = new int[1] ;
         T000B8_A86LocCodi = new int[1] ;
         T000B8_A95LocTotV = new decimal[1] ;
         T000B8_n95LocTotV = new bool[] {false} ;
         T000B8_A87LocSitu = new short[1] ;
         T000B8_n87LocSitu = new bool[] {false} ;
         T000B8_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         T000B8_n88LocDatL = new bool[] {false} ;
         T000B8_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         T000B8_n89LocDatD = new bool[] {false} ;
         T000B8_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         T000B8_n90LocDatC = new bool[] {false} ;
         T000B8_A91LocCliP = new int[1] ;
         T000B8_n91LocCliP = new bool[] {false} ;
         T000B8_A93LocVenP = new int[1] ;
         T000B8_n93LocVenP = new bool[] {false} ;
         RcdFound13 = 0 ;
         T000B13_A86LocCodi = new int[1] ;
         T000B14_A86LocCodi = new int[1] ;
         T000B7_A86LocCodi = new int[1] ;
         T000B7_A95LocTotV = new decimal[1] ;
         T000B7_n95LocTotV = new bool[] {false} ;
         T000B7_A87LocSitu = new short[1] ;
         T000B7_n87LocSitu = new bool[] {false} ;
         T000B7_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         T000B7_n88LocDatL = new bool[] {false} ;
         T000B7_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         T000B7_n89LocDatD = new bool[] {false} ;
         T000B7_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         T000B7_n90LocDatC = new bool[] {false} ;
         T000B7_A91LocCliP = new int[1] ;
         T000B7_n91LocCliP = new bool[] {false} ;
         T000B7_A93LocVenP = new int[1] ;
         T000B7_n93LocVenP = new bool[] {false} ;
         Gx_longc = false ;
         T000B9_A94LocVenP = new String[] {""} ;
         T000B9_n94LocVenP = new bool[] {false} ;
         T000B16_A86LocCodi = new int[1] ;
         T000B19_A92LocCliP = new String[] {""} ;
         T000B19_n92LocCliP = new bool[] {false} ;
         T000B20_A94LocVenP = new String[] {""} ;
         T000B20_n94LocVenP = new bool[] {false} ;
         T000B21_A37MidCodi = new int[1] ;
         T000B5_A86LocCodi = new int[1] ;
         T000B5_A103LocMid = new int[1] ;
         T000B5_n103LocMid = new bool[] {false} ;
         T000B5_A104LocMid = new String[] {""} ;
         T000B5_n104LocMid = new bool[] {false} ;
         T000B5_A106LocMid = new short[1] ;
         T000B5_n106LocMid = new bool[] {false} ;
         T000B5_A108LocMid = new int[1] ;
         T000B5_n108LocMid = new bool[] {false} ;
         T000B5_A109LocMid = new decimal[1] ;
         T000B5_n109LocMid = new bool[] {false} ;
         T000B5_A102LocMid = new int[1] ;
         T000B5_A105LocMid = new int[1] ;
         T000B5_n105LocMid = new bool[] {false} ;
         T000B23_A86LocCodi = new int[1] ;
         Z102LocMid = 0 ;
         T000B6_A118LocMid = new String[] {""} ;
         T000B6_n118LocMid = new bool[] {false} ;
         T000B24_A86LocCodi = new int[1] ;
         T000B24_A103LocMid = new int[1] ;
         T000B24_n103LocMid = new bool[] {false} ;
         T000B24_A104LocMid = new String[] {""} ;
         T000B24_n104LocMid = new bool[] {false} ;
         T000B24_A118LocMid = new String[] {""} ;
         T000B24_n118LocMid = new bool[] {false} ;
         T000B24_A106LocMid = new short[1] ;
         T000B24_n106LocMid = new bool[] {false} ;
         T000B24_A107LocMid = new short[1] ;
         T000B24_n107LocMid = new bool[] {false} ;
         T000B24_A108LocMid = new int[1] ;
         T000B24_n108LocMid = new bool[] {false} ;
         T000B24_A109LocMid = new decimal[1] ;
         T000B24_n109LocMid = new bool[] {false} ;
         T000B24_A102LocMid = new int[1] ;
         T000B24_A105LocMid = new int[1] ;
         T000B24_n105LocMid = new bool[] {false} ;
         T000B25_A86LocCodi = new int[1] ;
         T000B25_A102LocMid = new int[1] ;
         T000B4_A86LocCodi = new int[1] ;
         T000B4_A103LocMid = new int[1] ;
         T000B4_n103LocMid = new bool[] {false} ;
         T000B4_A104LocMid = new String[] {""} ;
         T000B4_n104LocMid = new bool[] {false} ;
         T000B4_A106LocMid = new short[1] ;
         T000B4_n106LocMid = new bool[] {false} ;
         T000B4_A108LocMid = new int[1] ;
         T000B4_n108LocMid = new bool[] {false} ;
         T000B4_A109LocMid = new decimal[1] ;
         T000B4_n109LocMid = new bool[] {false} ;
         T000B4_A102LocMid = new int[1] ;
         T000B4_A105LocMid = new int[1] ;
         T000B4_n105LocMid = new bool[] {false} ;
         T000B29_A107LocMid = new short[1] ;
         T000B29_n107LocMid = new bool[] {false} ;
         T000B30_A86LocCodi = new int[1] ;
         T000B30_A102LocMid = new int[1] ;
         A94LocVenP = AV7Funcion.gxTpr_Pesnome ;
         n94LocVenP = false ;
         A93LocVenP = AV7Funcion.gxTpr_Pescodigo ;
         n93LocVenP = false ;
         A88LocDatL = Gx_date ;
         n88LocDatL = false ;
         Gx_date = DateTimeUtil.Today( ) ;
         A87LocSitu = 1 ;
         n87LocSitu = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tlocacao__default(),
            new Object[][] {
                new Object[] {
               T000B2_A92LocCliP, T000B2_n92LocCliP
               }
               , new Object[] {
               T000B3_A107LocMid, T000B3_n107LocMid
               }
               , new Object[] {
               T000B4_A86LocCodi, T000B4_A103LocMid, T000B4_n103LocMid, T000B4_A104LocMid, T000B4_n104LocMid, T000B4_A106LocMid, T000B4_n106LocMid, T000B4_A108LocMid, T000B4_n108LocMid, T000B4_A109LocMid,
               T000B4_n109LocMid, T000B4_A102LocMid, T000B4_A105LocMid, T000B4_n105LocMid
               }
               , new Object[] {
               T000B5_A86LocCodi, T000B5_A103LocMid, T000B5_n103LocMid, T000B5_A104LocMid, T000B5_n104LocMid, T000B5_A106LocMid, T000B5_n106LocMid, T000B5_A108LocMid, T000B5_n108LocMid, T000B5_A109LocMid,
               T000B5_n109LocMid, T000B5_A102LocMid, T000B5_A105LocMid, T000B5_n105LocMid
               }
               , new Object[] {
               T000B6_A118LocMid, T000B6_n118LocMid
               }
               , new Object[] {
               T000B7_A86LocCodi, T000B7_A95LocTotV, T000B7_n95LocTotV, T000B7_A87LocSitu, T000B7_n87LocSitu, T000B7_A88LocDatL, T000B7_n88LocDatL, T000B7_A89LocDatD, T000B7_n89LocDatD, T000B7_A90LocDatC,
               T000B7_n90LocDatC, T000B7_A91LocCliP, T000B7_n91LocCliP, T000B7_A93LocVenP, T000B7_n93LocVenP
               }
               , new Object[] {
               T000B8_A86LocCodi, T000B8_A95LocTotV, T000B8_n95LocTotV, T000B8_A87LocSitu, T000B8_n87LocSitu, T000B8_A88LocDatL, T000B8_n88LocDatL, T000B8_A89LocDatD, T000B8_n89LocDatD, T000B8_A90LocDatC,
               T000B8_n90LocDatC, T000B8_A91LocCliP, T000B8_n91LocCliP, T000B8_A93LocVenP, T000B8_n93LocVenP
               }
               , new Object[] {
               T000B9_A94LocVenP, T000B9_n94LocVenP
               }
               , new Object[] {
               T000B10_A94LocVenP, T000B10_n94LocVenP
               }
               , new Object[] {
               T000B11_A86LocCodi, T000B11_A95LocTotV, T000B11_n95LocTotV, T000B11_A87LocSitu, T000B11_n87LocSitu, T000B11_A88LocDatL, T000B11_n88LocDatL, T000B11_A89LocDatD, T000B11_n89LocDatD, T000B11_A90LocDatC,
               T000B11_n90LocDatC, T000B11_A92LocCliP, T000B11_n92LocCliP, T000B11_A94LocVenP, T000B11_n94LocVenP, T000B11_A91LocCliP, T000B11_n91LocCliP, T000B11_A93LocVenP, T000B11_n93LocVenP
               }
               , new Object[] {
               T000B12_A86LocCodi
               }
               , new Object[] {
               T000B13_A86LocCodi
               }
               , new Object[] {
               T000B14_A86LocCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000B16_A86LocCodi
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B19_A92LocCliP, T000B19_n92LocCliP
               }
               , new Object[] {
               T000B20_A94LocVenP, T000B20_n94LocVenP
               }
               , new Object[] {
               T000B21_A37MidCodi
               }
               , new Object[] {
               }
               , new Object[] {
               T000B23_A86LocCodi
               }
               , new Object[] {
               T000B24_A86LocCodi, T000B24_A103LocMid, T000B24_n103LocMid, T000B24_A104LocMid, T000B24_n104LocMid, T000B24_A118LocMid, T000B24_n118LocMid, T000B24_A106LocMid, T000B24_n106LocMid, T000B24_A107LocMid,
               T000B24_n107LocMid, T000B24_A108LocMid, T000B24_n108LocMid, T000B24_A109LocMid, T000B24_n109LocMid, T000B24_A102LocMid, T000B24_A105LocMid, T000B24_n105LocMid
               }
               , new Object[] {
               T000B25_A86LocCodi, T000B25_A102LocMid
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B29_A107LocMid, T000B29_n107LocMid
               }
               , new Object[] {
               T000B30_A86LocCodi, T000B30_A102LocMid
               }
            }
         );
         reloadDynamicLists(0);
         ((GXComboBox) subGrd.getColumn(2).getGXComponent()).setTransactionMode(java.lang.Class.FromType(typeof(java.lang.Short)));
         A94LocVenP = AV7Funcion.gxTpr_Pesnome ;
         edtLocVenPesNome.setValue(A94LocVenP);
         n94LocVenP = false ;
         A93LocVenP = AV7Funcion.gxTpr_Pescodigo ;
         edtLocVenPesCodigo.setValue(A93LocVenP);
         n93LocVenP = false ;
         A88LocDatL = Gx_date ;
         edtLocDatLocacao.setValue(A88LocDatL);
         n88LocDatL = false ;
         Gx_date = DateTimeUtil.Today( ) ;
         A87LocSitu = 1 ;
         cmbLocSituacao.setValue(A87LocSitu);
         n87LocSitu = false ;
      }

      protected short IsConfirmed ;
      protected short IsModified ;
      protected short nKeyPressed ;
      protected short A87LocSitu ;
      protected short geteqAfterKey= 1 ;
      protected short i87LocSitu ;
      protected short A106LocMid ;
      protected short A107LocMid ;
      protected short geteqAfterKey13= 1 ;
      protected short Z106LocMid ;
      protected short AV18Y ;
      protected short AV14AtzLoc ;
      protected short RcdFound12 ;
      protected short Z87LocSitu ;
      protected short Gx_BScreen ;
      protected short RcdFound13 ;
      protected short nGXsfl_30_idx=1 ;
      protected int trnEnded ;
      protected int A91LocCliP ;
      protected int A93LocVenP ;
      protected int A86LocCodi ;
      protected int K86LocCodi ;
      protected int i93LocVenP ;
      protected int A103LocMid ;
      protected int A105LocMid ;
      protected int A108LocMid ;
      protected int A102LocMid ;
      protected int K102LocMid ;
      protected int AV19LocCod ;
      protected int lastAnyError ;
      protected int Z103LocMid ;
      protected int Z108LocMid ;
      protected int Z105LocMid ;
      protected int Z91LocCliP ;
      protected int Z93LocVenP ;
      protected int GX_JID ;
      protected int Z86LocCodi ;
      protected int Z102LocMid ;
      protected decimal A95LocTotV ;
      protected decimal A109LocMid ;
      protected decimal AV20LocTot ;
      protected decimal Z109LocMid ;
      protected decimal Z95LocTotV ;
      protected String PreviousTooltip ;
      protected String PreviousCaption ;
      protected String sMode13 ;
      protected String scmdbuf ;
      protected String sMode12 ;
      protected DateTime A88LocDatL ;
      protected DateTime Gx_date ;
      protected DateTime A89LocDatD ;
      protected DateTime A90LocDatC ;
      protected DateTime i88LocDatL ;
      protected DateTime Z88LocDatL ;
      protected DateTime Z89LocDatD ;
      protected DateTime Z90LocDatC ;
      protected bool n95LocTotV ;
      protected bool n87LocSitu ;
      protected bool n88LocDatL ;
      protected bool n89LocDatD ;
      protected bool n90LocDatC ;
      protected bool n91LocCliP ;
      protected bool n92LocCliP ;
      protected bool n93LocVenP ;
      protected bool n94LocVenP ;
      protected bool n103LocMid ;
      protected bool n104LocMid ;
      protected bool n105LocMid ;
      protected bool n118LocMid ;
      protected bool n106LocMid ;
      protected bool n108LocMid ;
      protected bool n109LocMid ;
      protected bool n107LocMid ;
      protected bool returnInSub ;
      protected bool Gx_longc ;
      protected String A92LocCliP ;
      protected String A94LocVenP ;
      protected String A104LocMid ;
      protected String A118LocMid ;
      protected String Z104LocMid ;
      protected String GXt_svchar1 ;
      protected String AV25MsgErr ;
      protected String Z94LocVenP ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectDecimal2 edtavLoctotvalor ;
      protected IGXButton bttEnter ;
      protected ILabel lbllbl36 ;
      protected GXTabControl tctrlCadastrodelocacao ;
      protected GXTabPage tpagetpage3 ;
      protected GUIObjectInt edtLocCodigo ;
      protected GUIObjectShort cmbLocSituacao ;
      protected GUIObjectDatetime edtLocDatLocacao ;
      protected GUIObjectDatetime edtLocDatDevolucao ;
      protected GUIObjectDatetime edtLocDatCancelamento ;
      protected GUIObjectInt edtLocCliPesCodigo ;
      protected GUIObjectString edtLocCliPesNome ;
      protected GUIObjectInt edtLocVenPesCodigo ;
      protected GUIObjectString edtLocVenPesNome ;
      protected ILabel lbllbl16 ;
      protected ILabel lbllbl5 ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl22 ;
      protected ILabel lbllbl18 ;
      protected ILabel lbllbl20 ;
      protected ILabel lbllbl27 ;
      protected ILabel lbllbl24 ;
      protected ILabel lbllbl25 ;
      protected IGXRectangle rctrct26 ;
      protected IGXRectangle rctrct23 ;
      protected IGXRectangle rctrct21 ;
      protected GXTabPage tpagetpage28 ;
      protected GXSubfileTRN subGrd ;
      protected ILabel lbllbl29 ;
      protected subtlocacao30 subtlocacao30 ;
      protected IDataReader T000B2 ;
      protected IDataStoreProvider pr_default ;
      protected String[] T000B2_A92LocCliP ;
      protected bool[] T000B2_n92LocCliP ;
      protected IDataReader T000B3 ;
      protected short[] T000B3_A107LocMid ;
      protected bool[] T000B3_n107LocMid ;
      protected IDataReader T000B4 ;
      protected IDataReader T000B5 ;
      protected IDataReader T000B6 ;
      protected IDataReader T000B7 ;
      protected IDataReader T000B8 ;
      protected IDataReader T000B9 ;
      protected IDataReader T000B10 ;
      protected String[] T000B10_A94LocVenP ;
      protected bool[] T000B10_n94LocVenP ;
      protected IDataReader T000B11 ;
      protected int[] T000B11_A86LocCodi ;
      protected decimal[] T000B11_A95LocTotV ;
      protected bool[] T000B11_n95LocTotV ;
      protected short[] T000B11_A87LocSitu ;
      protected bool[] T000B11_n87LocSitu ;
      protected DateTime[] T000B11_A88LocDatL ;
      protected bool[] T000B11_n88LocDatL ;
      protected DateTime[] T000B11_A89LocDatD ;
      protected bool[] T000B11_n89LocDatD ;
      protected DateTime[] T000B11_A90LocDatC ;
      protected bool[] T000B11_n90LocDatC ;
      protected String[] T000B11_A92LocCliP ;
      protected bool[] T000B11_n92LocCliP ;
      protected String[] T000B11_A94LocVenP ;
      protected bool[] T000B11_n94LocVenP ;
      protected int[] T000B11_A91LocCliP ;
      protected bool[] T000B11_n91LocCliP ;
      protected int[] T000B11_A93LocVenP ;
      protected bool[] T000B11_n93LocVenP ;
      protected IDataReader T000B12 ;
      protected int[] T000B12_A86LocCodi ;
      protected int[] T000B8_A86LocCodi ;
      protected decimal[] T000B8_A95LocTotV ;
      protected bool[] T000B8_n95LocTotV ;
      protected short[] T000B8_A87LocSitu ;
      protected bool[] T000B8_n87LocSitu ;
      protected DateTime[] T000B8_A88LocDatL ;
      protected bool[] T000B8_n88LocDatL ;
      protected DateTime[] T000B8_A89LocDatD ;
      protected bool[] T000B8_n89LocDatD ;
      protected DateTime[] T000B8_A90LocDatC ;
      protected bool[] T000B8_n90LocDatC ;
      protected int[] T000B8_A91LocCliP ;
      protected bool[] T000B8_n91LocCliP ;
      protected int[] T000B8_A93LocVenP ;
      protected bool[] T000B8_n93LocVenP ;
      protected IDataReader T000B13 ;
      protected int[] T000B13_A86LocCodi ;
      protected IDataReader T000B14 ;
      protected int[] T000B14_A86LocCodi ;
      protected int[] T000B7_A86LocCodi ;
      protected decimal[] T000B7_A95LocTotV ;
      protected bool[] T000B7_n95LocTotV ;
      protected short[] T000B7_A87LocSitu ;
      protected bool[] T000B7_n87LocSitu ;
      protected DateTime[] T000B7_A88LocDatL ;
      protected bool[] T000B7_n88LocDatL ;
      protected DateTime[] T000B7_A89LocDatD ;
      protected bool[] T000B7_n89LocDatD ;
      protected DateTime[] T000B7_A90LocDatC ;
      protected bool[] T000B7_n90LocDatC ;
      protected int[] T000B7_A91LocCliP ;
      protected bool[] T000B7_n91LocCliP ;
      protected int[] T000B7_A93LocVenP ;
      protected bool[] T000B7_n93LocVenP ;
      protected String[] T000B9_A94LocVenP ;
      protected bool[] T000B9_n94LocVenP ;
      protected IDataReader T000B16 ;
      protected int[] T000B16_A86LocCodi ;
      protected IDataReader T000B19 ;
      protected String[] T000B19_A92LocCliP ;
      protected bool[] T000B19_n92LocCliP ;
      protected IDataReader T000B20 ;
      protected String[] T000B20_A94LocVenP ;
      protected bool[] T000B20_n94LocVenP ;
      protected IDataReader T000B21 ;
      protected int[] T000B21_A37MidCodi ;
      protected int[] T000B5_A86LocCodi ;
      protected int[] T000B5_A103LocMid ;
      protected bool[] T000B5_n103LocMid ;
      protected String[] T000B5_A104LocMid ;
      protected bool[] T000B5_n104LocMid ;
      protected short[] T000B5_A106LocMid ;
      protected bool[] T000B5_n106LocMid ;
      protected int[] T000B5_A108LocMid ;
      protected bool[] T000B5_n108LocMid ;
      protected decimal[] T000B5_A109LocMid ;
      protected bool[] T000B5_n109LocMid ;
      protected int[] T000B5_A102LocMid ;
      protected int[] T000B5_A105LocMid ;
      protected bool[] T000B5_n105LocMid ;
      protected IDataReader T000B23 ;
      protected int[] T000B23_A86LocCodi ;
      protected String[] T000B6_A118LocMid ;
      protected bool[] T000B6_n118LocMid ;
      protected IDataReader T000B24 ;
      protected int[] T000B24_A86LocCodi ;
      protected int[] T000B24_A103LocMid ;
      protected bool[] T000B24_n103LocMid ;
      protected String[] T000B24_A104LocMid ;
      protected bool[] T000B24_n104LocMid ;
      protected String[] T000B24_A118LocMid ;
      protected bool[] T000B24_n118LocMid ;
      protected short[] T000B24_A106LocMid ;
      protected bool[] T000B24_n106LocMid ;
      protected short[] T000B24_A107LocMid ;
      protected bool[] T000B24_n107LocMid ;
      protected int[] T000B24_A108LocMid ;
      protected bool[] T000B24_n108LocMid ;
      protected decimal[] T000B24_A109LocMid ;
      protected bool[] T000B24_n109LocMid ;
      protected int[] T000B24_A102LocMid ;
      protected int[] T000B24_A105LocMid ;
      protected bool[] T000B24_n105LocMid ;
      protected IDataReader T000B25 ;
      protected int[] T000B25_A86LocCodi ;
      protected int[] T000B25_A102LocMid ;
      protected int[] T000B4_A86LocCodi ;
      protected int[] T000B4_A103LocMid ;
      protected bool[] T000B4_n103LocMid ;
      protected String[] T000B4_A104LocMid ;
      protected bool[] T000B4_n104LocMid ;
      protected short[] T000B4_A106LocMid ;
      protected bool[] T000B4_n106LocMid ;
      protected int[] T000B4_A108LocMid ;
      protected bool[] T000B4_n108LocMid ;
      protected decimal[] T000B4_A109LocMid ;
      protected bool[] T000B4_n109LocMid ;
      protected int[] T000B4_A102LocMid ;
      protected int[] T000B4_A105LocMid ;
      protected bool[] T000B4_n105LocMid ;
      protected IDataReader T000B29 ;
      protected short[] T000B29_A107LocMid ;
      protected bool[] T000B29_n107LocMid ;
      protected IDataReader T000B30 ;
      protected int[] T000B30_A86LocCodi ;
      protected int[] T000B30_A102LocMid ;
      protected SdtSDTFuncionario AV7Funcion ;
   }

   public class tlocacao__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[12])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[13])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[14])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[15])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[16])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[17])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[18])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[19])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[20])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[21])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[22])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[23])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[24])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[25])
         ,new GeneXus.Data.NTier.ADO.UpdateCursor(def[26])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[27])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[28])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmT000B11 ;
          prmT000B11 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B2 ;
          prmT000B2 = new Object[] {
          new Object[] {"@LocCliPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B10 ;
          prmT000B10 = new Object[] {
          new Object[] {"@LocVenPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B12 ;
          prmT000B12 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B8 ;
          prmT000B8 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B13 ;
          prmT000B13 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B14 ;
          prmT000B14 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B7 ;
          prmT000B7 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B9 ;
          prmT000B9 = new Object[] {
          new Object[] {"@LocVenPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B15 ;
          prmT000B15 = new Object[] {
          new Object[] {"@LocTotValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@LocSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocDatLocacao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocDatDevolucao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocDatCancelamento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocCliPesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocVenPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B16 ;
          prmT000B16 = new Object[] {
          } ;
          Object[] prmT000B17 ;
          prmT000B17 = new Object[] {
          new Object[] {"@LocTotValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@LocSituacao",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocDatLocacao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocDatDevolucao",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocDatCancelamento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LocCliPesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocVenPesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B18 ;
          prmT000B18 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B19 ;
          prmT000B19 = new Object[] {
          new Object[] {"@LocCliPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B20 ;
          prmT000B20 = new Object[] {
          new Object[] {"@LocVenPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B21 ;
          prmT000B21 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B22 ;
          prmT000B22 = new Object[] {
          new Object[] {"@LocVenPesNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@LocVenPesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B23 ;
          prmT000B23 = new Object[] {
          } ;
          Object[] prmT000B6 ;
          prmT000B6 = new Object[] {
          new Object[] {"@LocMidCatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B24 ;
          prmT000B24 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B3 ;
          prmT000B3 = new Object[] {
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B25 ;
          prmT000B25 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B5 ;
          prmT000B5 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B4 ;
          prmT000B4 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B26 ;
          prmT000B26 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidFilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidFilNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@LocMidMidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocMidMidLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidConfValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidCatCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B27 ;
          prmT000B27 = new Object[] {
          new Object[] {"@LocMidFilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidFilNome",SqlDbType.VarChar,50,0} ,
          new Object[] {"@LocMidMidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@LocMidMidLocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidConfValor",SqlDbType.Decimal,12,2} ,
          new Object[] {"@LocMidCatCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B28 ;
          prmT000B28 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B29 ;
          prmT000B29 = new Object[] {
          new Object[] {"@LocMidMidCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmT000B30 ;
          prmT000B30 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("T000B2", "SELECT [PesNome] AS LocCliPesNome FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @LocCliPesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B3", "SELECT [MidSituacao] AS LocMidMidSituacao FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @LocMidMidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B4", "SELECT [LocCodigo], [LocMidFilCodigo], [LocMidFilNome], [LocMidMidTipo], [LocMidMidLocCodigo], [LocMidMidConfValor], [LocMidMidCodigo] AS LocMidMidCodigo, [LocMidCatCodigo] AS LocMidCatCodigo FROM [LOCACAOLOCACAOMIDIA] WITH (UPDLOCK) WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B5", "SELECT [LocCodigo], [LocMidFilCodigo], [LocMidFilNome], [LocMidMidTipo], [LocMidMidLocCodigo], [LocMidMidConfValor], [LocMidMidCodigo] AS LocMidMidCodigo, [LocMidCatCodigo] AS LocMidCatCodigo FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B6", "SELECT [CatNome] AS LocMidCatNome FROM [CATEGORIA] WITH (NOLOCK) WHERE [CatCodigo] = @LocMidCatCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B7", "SELECT [LocCodigo], [LocTotValor], [LocSituacao], [LocDatLocacao], [LocDatDevolucao], [LocDatCancelamento], [LocCliPesCodigo] AS LocCliPesCodigo, [LocVenPesCodigo] AS LocVenPesCodigo FROM [LOCACAO] WITH (UPDLOCK) WHERE [LocCodigo] = @LocCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B8", "SELECT [LocCodigo], [LocTotValor], [LocSituacao], [LocDatLocacao], [LocDatDevolucao], [LocDatCancelamento], [LocCliPesCodigo] AS LocCliPesCodigo, [LocVenPesCodigo] AS LocVenPesCodigo FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCodigo] = @LocCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B8,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B9", "SELECT [PesNome] AS LocVenPesNome FROM [PESSOA] WITH (UPDLOCK) WHERE [PesCodigo] = @LocVenPesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B9,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B10", "SELECT [PesNome] AS LocVenPesNome FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @LocVenPesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B10,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B11", "SELECT TM1.[LocCodigo], TM1.[LocTotValor], TM1.[LocSituacao], TM1.[LocDatLocacao], TM1.[LocDatDevolucao], TM1.[LocDatCancelamento], T3.[PesNome] AS LocCliPesNome, T2.[PesNome] AS LocVenPesNome, TM1.[LocCliPesCodigo] AS LocCliPesCodigo, TM1.[LocVenPesCodigo] AS LocVenPesCodigo FROM (([LOCACAO] TM1 WITH (NOLOCK) LEFT JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = TM1.[LocVenPesCodigo]) LEFT JOIN [PESSOA] T3 WITH (NOLOCK) ON T3.[PesCodigo] = TM1.[LocCliPesCodigo]) WHERE TM1.[LocCodigo] = @LocCodigo ORDER BY TM1.[LocCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B11,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B12", "SELECT [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCodigo] = @LocCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B12,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B13", "SELECT TOP 1 [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE ( [LocCodigo] > @LocCodigo) ORDER BY [LocCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B13,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B14", "SELECT TOP 1 [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) WHERE ( [LocCodigo] < @LocCodigo) ORDER BY [LocCodigo] DESC ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B14,100,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B15", "INSERT INTO [LOCACAO] ([LocTotValor], [LocSituacao], [LocDatLocacao], [LocDatDevolucao], [LocDatCancelamento], [LocCliPesCodigo], [LocVenPesCodigo]) VALUES (@LocTotValor, @LocSituacao, @LocDatLocacao, @LocDatDevolucao, @LocDatCancelamento, @LocCliPesCodigo, @LocVenPesCodigo)", GxErrorMask.GX_NOMASK,prmT000B15)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B16", "SELECT @@IDENTITY ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B16,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B17", "UPDATE [LOCACAO] SET [LocTotValor]=@LocTotValor, [LocSituacao]=@LocSituacao, [LocDatLocacao]=@LocDatLocacao, [LocDatDevolucao]=@LocDatDevolucao, [LocDatCancelamento]=@LocDatCancelamento, [LocCliPesCodigo]=@LocCliPesCodigo, [LocVenPesCodigo]=@LocVenPesCodigo  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK,prmT000B17)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B18", "DELETE FROM [LOCACAO]  WHERE [LocCodigo] = @LocCodigo", GxErrorMask.GX_NOMASK,prmT000B18)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B19", "SELECT [PesNome] AS LocCliPesNome FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @LocCliPesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B19,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B20", "SELECT [PesNome] AS LocVenPesNome FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @LocVenPesCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B20,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B21", "SELECT TOP 1 [MidCodigo] FROM [MIDIA] WITH (NOLOCK) WHERE [LocCodLocCodigo] = @LocCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B21,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B22", "UPDATE [PESSOA] SET [PesNome]=@LocVenPesNome  WHERE [PesCodigo] = @LocVenPesCodigo", GxErrorMask.GX_NOMASK,prmT000B22)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B23", "SELECT [LocCodigo] FROM [LOCACAO] WITH (NOLOCK) ORDER BY [LocCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B23,100,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B24", "SELECT T1.[LocCodigo], T1.[LocMidFilCodigo], T1.[LocMidFilNome], T2.[CatNome] AS LocMidCatNome, T1.[LocMidMidTipo], T3.[MidSituacao] AS LocMidMidSituacao, T1.[LocMidMidLocCodigo], T1.[LocMidMidConfValor], T1.[LocMidMidCodigo] AS LocMidMidCodigo, T1.[LocMidCatCodigo] AS LocMidCatCodigo FROM (([LOCACAOLOCACAOMIDIA] T1 WITH (NOLOCK) LEFT JOIN [CATEGORIA] T2 WITH (NOLOCK) ON T2.[CatCodigo] = T1.[LocMidCatCodigo]) INNER JOIN [MIDIA] T3 WITH (NOLOCK) ON T3.[MidCodigo] = T1.[LocMidMidCodigo]) WHERE T1.[LocCodigo] = @LocCodigo and T1.[LocMidMidCodigo] = @LocMidMidCodigo ORDER BY T1.[LocCodigo], T1.[LocMidMidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B24,16,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B25", "SELECT [LocCodigo], [LocMidMidCodigo] AS LocMidMidCodigo FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B25,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B26", "INSERT INTO [LOCACAOLOCACAOMIDIA] ([LocCodigo], [LocMidFilCodigo], [LocMidFilNome], [LocMidMidTipo], [LocMidMidLocCodigo], [LocMidMidConfValor], [LocMidMidCodigo], [LocMidCatCodigo]) VALUES (@LocCodigo, @LocMidFilCodigo, @LocMidFilNome, @LocMidMidTipo, @LocMidMidLocCodigo, @LocMidMidConfValor, @LocMidMidCodigo, @LocMidCatCodigo)", GxErrorMask.GX_NOMASK,prmT000B26)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B27", "UPDATE [LOCACAOLOCACAOMIDIA] SET [LocMidFilCodigo]=@LocMidFilCodigo, [LocMidFilNome]=@LocMidFilNome, [LocMidMidTipo]=@LocMidMidTipo, [LocMidMidLocCodigo]=@LocMidMidLocCodigo, [LocMidMidConfValor]=@LocMidMidConfValor, [LocMidCatCodigo]=@LocMidCatCodigo  WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK,prmT000B27)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B28", "DELETE FROM [LOCACAOLOCACAOMIDIA]  WHERE [LocCodigo] = @LocCodigo AND [LocMidMidCodigo] = @LocMidMidCodigo", GxErrorMask.GX_NOMASK,prmT000B28)
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B29", "SELECT [MidSituacao] AS LocMidMidSituacao FROM [MIDIA] WITH (NOLOCK) WHERE [MidCodigo] = @LocMidMidCodigo ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B29,1,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("T000B30", "SELECT [LocCodigo], [LocMidMidCodigo] AS LocMidMidCodigo FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) WHERE [LocCodigo] = @LocCodigo ORDER BY [LocCodigo], [LocMidMidCodigo] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B30,16,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((int[]) buf[7])[0] = rslt.getInt(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((int[]) buf[13])[0] = rslt.getInt(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((int[]) buf[13])[0] = rslt.getInt(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((int[]) buf[17])[0] = rslt.getInt(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 12 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 19 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 21 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 22 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((short[]) buf[7])[0] = rslt.getShort(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((int[]) buf[15])[0] = rslt.getInt(9) ;
                ((int[]) buf[16])[0] = rslt.getInt(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                break;
             case 23 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 27 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 28 :
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 13 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[13]);
                }
                break;
             case 15 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (decimal)parms[1]);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(2, (short)parms[3]);
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
                   stmt.setNull( 4 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(4, (DateTime)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(5, (DateTime)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 7 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(7, (int)parms[13]);
                }
                stmt.SetParameter(8, (int)parms[14]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 19 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 20 :
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
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[3]);
                }
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(2, (int)parms[2]);
                }
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(4, (short)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(5, (int)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(6, (decimal)parms[10]);
                }
                stmt.SetParameter(7, (int)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 8 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(8, (int)parms[13]);
                }
                break;
             case 25 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
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
                   stmt.setNull( 3 , SqlDbType.SmallInt );
                }
                else
                {
                   stmt.SetParameter(3, (short)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 4 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(4, (int)parms[7]);
                }
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (decimal)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[11]);
                }
                stmt.SetParameter(7, (int)parms[12]);
                stmt.SetParameter(8, (int)parms[13]);
                break;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 27 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 28 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
