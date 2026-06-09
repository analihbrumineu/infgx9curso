/*
               File: Gx00D1
        Description: Lista de Seleção Dados da mídia locada
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 11:37:37.87
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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wgx00d1 : GXWorkpanel
   {
      public wgx00d1( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx00d1( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx00d1( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx00D1" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Dados da mídia locada" ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return ApplicationUI.getDefaultMenuBar(this) ;
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
         return 550 ;
      }

      public override int getFrmHeight( )
      {
         return 402 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx00D1.htm";
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

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( int aP0_LocCodigo ,
                           out int aP1_pLocMidMidCodigo )
      {
         this.A86LocCodi = aP0_LocCodigo;
         this.AV11pLocMi = 0 ;
         executePrivate();
         aP1_pLocMidMidCodigo=this.AV11pLocMi;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load20( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx00d120 = new subwgx00d120 ();
         /* Using cursor W002J2 */
         pr_default.execute(0, new Object[] {A86LocCodi, AV5cLocMid, AV6cLocMid, AV7cLocMid, AV8cLocMid, AV9cLocMid, AV10cLocMi});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A105LocMid = W002J2_A105LocMid[0] ;
            n105LocMid = W002J2_n105LocMid[0] ;
            A106LocMid = W002J2_A106LocMid[0] ;
            n106LocMid = W002J2_n106LocMid[0] ;
            A108LocMid = W002J2_A108LocMid[0] ;
            n108LocMid = W002J2_n108LocMid[0] ;
            A109LocMid = W002J2_A109LocMid[0] ;
            n109LocMid = W002J2_n109LocMid[0] ;
            A103LocMid = W002J2_A103LocMid[0] ;
            n103LocMid = W002J2_n103LocMid[0] ;
            A102LocMid = W002J2_A102LocMid[0] ;
            /* Execute user event: E11V2J2 */
            E11V2J2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx00D1_load20 : GXLoadProducer
      {
         wgx00d1 _sf ;

         public Gx00D1_load20( wgx00d1 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer20();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load20();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors20();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGrd_1.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow20( )
      {
         return true;
      }

      public void autoRefresh_flow20( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cLocMid!=cV5cLocMid)||(AV6cLocMid!=cV6cLocMid)||(AV7cLocMid!=cV7cLocMid)||(AV8cLocMid!=cV8cLocMid)||(AV9cLocMid!=cV9cLocMid)||(AV10cLocMi!=cV10cLocMi) ) || (!loadedFirstTime && ! isLoadAtStartup_flow20() )) {
            subfile.refresh();
            resetSubfileConditions_flow20() ;
         }
      }

      public bool getSearch_flow20( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow20( )
      {
         cV5cLocMid = AV5cLocMid ;
         cV6cLocMid = AV6cLocMid ;
         cV7cLocMid = AV7cLocMid ;
         cV8cLocMid = AV8cLocMid ;
         cV9cLocMid = AV9cLocMid ;
         cV10cLocMi = AV10cLocMi ;
      }

      public void resetSearchConditions_flow20( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow20( )
      {
         return new subwgx00d120 ();
      }

      public bool getSearch_flow20( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow20( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow20( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow20( )
      {
         GXRefreshCommand20 ();
      }

      public class Gx00D1_flow20 : GXSubfileFlow
      {
         wgx00d1 _sf ;

         public Gx00D1_flow20( wgx00d1 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow20();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow20(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow20();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow20();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow20(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow20();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow20(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow20(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow20(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow20();
         }

      }

      protected void GXRefreshCommand20( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V2J2 */
         E12V2J2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2J2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV11pLocMi = A102LocMid ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer20( )
      {
         subwgx00d120 oAux = subwgx00d120 ;
         subwgx00d120 = new subwgx00d120 ();
         variablesToSubfile20 ();
         subGrd_1.addElement(subwgx00d120);
         subwgx00d120 = oAux;
      }

      private void E11V2J2( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors20( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 550 , 402 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtLocCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),294, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 294 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A86LocCodi" );
         ((GXEdit) edtLocCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtLocCodigo.addFocusListener(this);
         edtLocCodigo.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         edtavClocmidmidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),294, 48, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 294 , 48 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cLocMid" );
         ((GXEdit) edtavClocmidmidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocmidmidcodigo.addFocusListener(this);
         edtavClocmidmidcodigo.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         edtavClocmidfilcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),294, 72, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 294 , 72 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cLocMid" );
         ((GXEdit) edtavClocmidfilcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocmidfilcodigo.addFocusListener(this);
         edtavClocmidfilcodigo.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         edtavClocmidcatcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),294, 96, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 294 , 96 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7cLocMid" );
         ((GXEdit) edtavClocmidcatcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocmidcatcodigo.addFocusListener(this);
         edtavClocmidcatcodigo.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         cmbavClocmidmidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 294 , 120 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8cLocMid" );
         ((GXComboBox) cmbavClocmidmidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavClocmidmidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         cmbavClocmidmidtipo.addFocusListener(this);
         cmbavClocmidmidtipo.addItemListener(this);
         cmbavClocmidmidtipo.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         edtavClocmidmidloccodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),294, 144, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 294 , 144 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9cLocMid" );
         ((GXEdit) edtavClocmidmidloccodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocmidmidloccodigo.addFocusListener(this);
         edtavClocmidmidloccodigo.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         edtavClocmidmidconfvalor = new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),294, 168, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 294 , 168 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10cLocMi" );
         ((GXEdit) edtavClocmidmidconfvalor.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavClocmidmidconfvalor.addFocusListener(this);
         edtavClocmidmidconfvalor.getGXComponent().setHelpId("HLP_WGx00D1.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx00D1_load20(this), new Gx00D1_flow20(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 176, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 175 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A102LocMid" ), "Código da mídia a ser locada"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 175 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 171, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 170 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A103LocMid" ), "Código do filme a ser locado"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 170 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 192 , 403 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  442 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  442 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  442 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  442 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código da locação", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 107 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código da mídia a ser locada", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 167 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Código do filme a ser locado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 72 , 162 , 13 );
         lbllbl13 = UIFactory.getLabel(GXPanel1, "Código da categoria do filme a ser locado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 96 , 237 , 13 );
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Tipo da mídia a ser locada", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 120 , 153 , 13 );
         lbllbl17 = UIFactory.getLabel(GXPanel1, "Código da locação da mídia a ser locada", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 144 , 234 , 13 );
         lbllbl19 = UIFactory.getLabel(GXPanel1, "Valor da configuração da mídia a ser locada", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 168 , 253 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtLocCodigo ,
                   edtavClocmidmidcodigo ,
                   edtavClocmidfilcodigo ,
                   edtavClocmidcatcodigo ,
                   cmbavClocmidmidtipo ,
                   edtavClocmidmidloccodigo ,
                   edtavClocmidmidconfvalor ,
                   subGrd_1 ,
                   bttBtn_enter ,
                   bttBtn_cancel ,
                   bttBtn_refresh ,
                   bttBtn_help
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGrd_1, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile20( )
      {
         subwgx00d120.setLocMidMidCodigo(A102LocMid);
         subwgx00d120.setLocMidFilCodigo(A103LocMid);
         subwgx00d120.setLocCodigo(A86LocCodi);
      }

      protected void subfileToVariables20( )
      {
         A102LocMid = subwgx00d120.getLocMidMidCodigo();
         A103LocMid = subwgx00d120.getLocMidFilCodigo();
         A86LocCodi = subwgx00d120.getLocCodigo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtLocCodigo.setValue( A86LocCodi );
         edtavClocmidmidcodigo.setValue( AV5cLocMid );
         edtavClocmidfilcodigo.setValue( AV6cLocMid );
         edtavClocmidcatcodigo.setValue( AV7cLocMid );
         cmbavClocmidmidtipo.setValue( AV8cLocMid );
         edtavClocmidmidloccodigo.setValue( AV9cLocMid );
         edtavClocmidmidconfvalor.setValue( AV10cLocMi );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A86LocCodi = (int)(edtLocCodigo.getValue()) ;
         edtLocCodigo.setValue(A86LocCodi);
         AV5cLocMid = (int)(edtavClocmidmidcodigo.getValue()) ;
         edtavClocmidmidcodigo.setValue(AV5cLocMid);
         AV6cLocMid = (int)(edtavClocmidfilcodigo.getValue()) ;
         edtavClocmidfilcodigo.setValue(AV6cLocMid);
         AV7cLocMid = (int)(edtavClocmidcatcodigo.getValue()) ;
         edtavClocmidcatcodigo.setValue(AV7cLocMid);
         AV8cLocMid = (short)(cmbavClocmidmidtipo.getValue()) ;
         cmbavClocmidmidtipo.setValue(AV8cLocMid);
         AV9cLocMid = (int)(edtavClocmidmidloccodigo.getValue()) ;
         edtavClocmidmidloccodigo.setValue(AV9cLocMid);
         AV10cLocMi = (decimal)(edtavClocmidmidconfvalor.getValue()) ;
         edtavClocmidmidconfvalor.setValue(AV10cLocMi);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGrd_1.inValidElement() )
         {
            subwgx00d120 = ( subwgx00d120 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00d120 = new subwgx00d120 ();
         }
         subfileToVariables20 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile20 ();
         subGrd_1.refreshLineValue(subwgx00d120);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx00d120 = ( subwgx00d120 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00d120 = new subwgx00d120 ();
         }
         subfileToVariables20 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttBtn_cancel.isEventSource(eventSource) ) {
            if (canCleanup())
               this.cleanup();

            return;
         }
         if ( bttBtn_refresh.isEventSource(eventSource) ) {
            GXRefresh();
            return;
         }
         if ( bttBtn_help.isEventSource(eventSource) ) {
            showHelp();
            return;
         }
         if ( bttBtn_enter.isEventSource(eventSource) ) {
            /* Execute user event: E12V2J2 */
            E12V2J2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2J2 */
            E12V2J2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtLocCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtLocCodigo.getGXCursor() );
            return;
         }
         if ( edtavClocmidmidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavClocmidmidcodigo.getGXCursor() );
            return;
         }
         if ( edtavClocmidfilcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavClocmidfilcodigo.getGXCursor() );
            return;
         }
         if ( edtavClocmidcatcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavClocmidcatcodigo.getGXCursor() );
            return;
         }
         if ( cmbavClocmidmidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavClocmidmidtipo.getGXCursor() );
            return;
         }
         if ( edtavClocmidmidloccodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavClocmidmidloccodigo.getGXCursor() );
            return;
         }
         if ( edtavClocmidmidconfvalor.isEventSource(eventSource) ) {
            setGXCursor( edtavClocmidmidconfvalor.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtLocCodigo.isEventSource(eventSource) ) {
            A86LocCodi = edtLocCodigo.getValue() ;
            return;
         }
         if ( edtavClocmidmidcodigo.isEventSource(eventSource) ) {
            AV5cLocMid = edtavClocmidmidcodigo.getValue() ;
            return;
         }
         if ( edtavClocmidfilcodigo.isEventSource(eventSource) ) {
            AV6cLocMid = edtavClocmidfilcodigo.getValue() ;
            return;
         }
         if ( edtavClocmidcatcodigo.isEventSource(eventSource) ) {
            AV7cLocMid = edtavClocmidcatcodigo.getValue() ;
            return;
         }
         if ( cmbavClocmidmidtipo.isEventSource(eventSource) ) {
            AV8cLocMid = cmbavClocmidmidtipo.getValue() ;
            return;
         }
         if ( edtavClocmidmidloccodigo.isEventSource(eventSource) ) {
            AV9cLocMid = edtavClocmidmidloccodigo.getValue() ;
            return;
         }
         if ( edtavClocmidmidconfvalor.isEventSource(eventSource) ) {
            AV10cLocMi = edtavClocmidmidconfvalor.getValue() ;
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
            /* Execute user event: E12V2J2 */
            E12V2J2 ();
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public override IGXButton getCancelButton( )
      {
         return bttBtn_cancel ;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         this.AV11pLocMi = AV11pLocMi;
         stopThreads();
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
      }

      public override void initialize( )
      {
         subwgx00d120 = new subwgx00d120();
         scmdbuf = "" ;
         AV5cLocMid = 0 ;
         AV6cLocMid = 0 ;
         AV7cLocMid = 0 ;
         AV8cLocMid = 0 ;
         AV9cLocMid = 0 ;
         AV10cLocMi = (decimal)(0M) ;
         W002J2_A86LocCodi = new int[1] ;
         W002J2_A105LocMid = new int[1] ;
         W002J2_n105LocMid = new bool[] {false} ;
         W002J2_A106LocMid = new short[1] ;
         W002J2_n106LocMid = new bool[] {false} ;
         W002J2_A108LocMid = new int[1] ;
         W002J2_n108LocMid = new bool[] {false} ;
         W002J2_A109LocMid = new decimal[1] ;
         W002J2_n109LocMid = new bool[] {false} ;
         W002J2_A103LocMid = new int[1] ;
         W002J2_n103LocMid = new bool[] {false} ;
         W002J2_A102LocMid = new int[1] ;
         A105LocMid = 0 ;
         n105LocMid = false ;
         A106LocMid = 0 ;
         n106LocMid = false ;
         A108LocMid = 0 ;
         n108LocMid = false ;
         A109LocMid = (decimal)(0M) ;
         n109LocMid = false ;
         A103LocMid = 0 ;
         n103LocMid = false ;
         A102LocMid = 0 ;
         gxIsRefreshing = false ;
         cV5cLocMid = 0 ;
         cV6cLocMid = 0 ;
         cV7cLocMid = 0 ;
         cV8cLocMid = 0 ;
         cV9cLocMid = 0 ;
         cV10cLocMi = (decimal)(0M) ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx00d1__default(),
            new Object[][] {
                new Object[] {
               W002J2_A86LocCodi, W002J2_A105LocMid, W002J2_n105LocMid, W002J2_A106LocMid, W002J2_n106LocMid, W002J2_A108LocMid, W002J2_n108LocMid, W002J2_A109LocMid, W002J2_n109LocMid, W002J2_A103LocMid,
               W002J2_n103LocMid, W002J2_A102LocMid
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV8cLocMid ;
      protected short A106LocMid ;
      protected short cV8cLocMid ;
      protected int A86LocCodi ;
      protected int AV5cLocMid ;
      protected int AV6cLocMid ;
      protected int AV7cLocMid ;
      protected int AV9cLocMid ;
      protected int A105LocMid ;
      protected int A108LocMid ;
      protected int A103LocMid ;
      protected int A102LocMid ;
      protected int cV5cLocMid ;
      protected int cV6cLocMid ;
      protected int cV7cLocMid ;
      protected int cV9cLocMid ;
      protected int AV11pLocMi ;
      protected decimal AV10cLocMi ;
      protected decimal A109LocMid ;
      protected decimal cV10cLocMi ;
      protected String scmdbuf ;
      protected bool n105LocMid ;
      protected bool n106LocMid ;
      protected bool n108LocMid ;
      protected bool n109LocMid ;
      protected bool n103LocMid ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx00d120 subwgx00d120 ;
      protected IDataReader W002J2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W002J2_A86LocCodi ;
      protected int[] W002J2_A105LocMid ;
      protected bool[] W002J2_n105LocMid ;
      protected short[] W002J2_A106LocMid ;
      protected bool[] W002J2_n106LocMid ;
      protected int[] W002J2_A108LocMid ;
      protected bool[] W002J2_n108LocMid ;
      protected decimal[] W002J2_A109LocMid ;
      protected bool[] W002J2_n109LocMid ;
      protected int[] W002J2_A103LocMid ;
      protected bool[] W002J2_n103LocMid ;
      protected int[] W002J2_A102LocMid ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtLocCodigo ;
      protected GUIObjectInt edtavClocmidmidcodigo ;
      protected GUIObjectInt edtavClocmidfilcodigo ;
      protected GUIObjectInt edtavClocmidcatcodigo ;
      protected GUIObjectShort cmbavClocmidmidtipo ;
      protected GUIObjectInt edtavClocmidmidloccodigo ;
      protected GUIObjectDecimal2 edtavClocmidmidconfvalor ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl13 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl17 ;
      protected ILabel lbllbl19 ;
      protected int aP1_pLocMidMidCodigo ;
   }

   public class wgx00d1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW002J2 ;
          prmW002J2 = new Object[] {
          new Object[] {"@LocCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5cLocMid",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cLocMid",SqlDbType.Int,9,0} ,
          new Object[] {"@AV7cLocMid",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cLocMid",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV9cLocMid",SqlDbType.Int,9,0} ,
          new Object[] {"@AV10cLocMi",SqlDbType.Decimal,12,2}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002J2", "SELECT [LocCodigo], [LocMidCatCodigo], [LocMidMidTipo], [LocMidMidLocCodigo], [LocMidMidConfValor], [LocMidFilCodigo], [LocMidMidCodigo] FROM [LOCACAOLOCACAOMIDIA] WITH (NOLOCK) WHERE ([LocCodigo] = @LocCodigo and [LocMidMidCodigo] >= @AV5cLocMid) AND ([LocMidFilCodigo] >= @AV6cLocMid) AND ([LocMidCatCodigo] >= @AV7cLocMid) AND ([LocMidMidTipo] >= @AV8cLocMid) AND ([LocMidMidLocCodigo] >= @AV9cLocMid) AND ([LocMidMidConfValor] >= @AV10cLocMi) ORDER BY [LocCodigo], [LocMidMidCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002J2,9,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((int[]) buf[5])[0] = rslt.getInt(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((int[]) buf[9])[0] = rslt.getInt(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
       }
    }

 }

}
