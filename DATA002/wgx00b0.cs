/*
               File: Gx00B0
        Description: Lista de Seleção Configurações tipo de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:40:44.0
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
   public class wgx00b0 : GXWorkpanel
   {
      public wgx00b0( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx00b0( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx00b0( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx00B0" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Configurações tipo de mídia." ;
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
         return 598 ;
      }

      public override int getFrmHeight( )
      {
         return 306 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx00B0.htm";
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

      public void execute( out short aP0_pMidTipo ,
                           out int aP1_pCatCodigo )
      {
         this.AV8pMidTip = 0 ;
         this.AV9pCatCod = 0 ;
         executePrivate();
         aP0_pMidTipo=this.AV8pMidTip;
         aP1_pCatCodigo=this.AV9pCatCod;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load12( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx00b012 = new subwgx00b012 ();
         /* Using cursor W002H2 */
         pr_default.execute(0, new Object[] {AV5cMidTip, AV6cCatCod, AV7cConfTi});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A85ConfTip = W002H2_A85ConfTip[0] ;
            n85ConfTip = W002H2_n85ConfTip[0] ;
            A32CatCodi = W002H2_A32CatCodi[0] ;
            A35MidTipo = W002H2_A35MidTipo[0] ;
            /* Execute user event: E11V2H2 */
            E11V2H2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx00B0_load12 : GXLoadProducer
      {
         wgx00b0 _sf ;

         public Gx00B0_load12( wgx00b0 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer12();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load12();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors12();
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

      public bool isLoadAtStartup_flow12( )
      {
         return true;
      }

      public void autoRefresh_flow12( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cMidTip!=cV5cMidTip)||(AV6cCatCod!=cV6cCatCod)||(AV7cConfTi!=cV7cConfTi) ) || (!loadedFirstTime && ! isLoadAtStartup_flow12() )) {
            subfile.refresh();
            resetSubfileConditions_flow12() ;
         }
      }

      public bool getSearch_flow12( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow12( )
      {
         cV5cMidTip = AV5cMidTip ;
         cV6cCatCod = AV6cCatCod ;
         cV7cConfTi = AV7cConfTi ;
      }

      public void resetSearchConditions_flow12( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow12( )
      {
         return new subwgx00b012 ();
      }

      public bool getSearch_flow12( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow12( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow12( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow12( )
      {
         GXRefreshCommand12 ();
      }

      public class Gx00B0_flow12 : GXSubfileFlow
      {
         wgx00b0 _sf ;

         public Gx00B0_flow12( wgx00b0 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow12();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow12(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow12();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow12();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow12(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow12();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow12(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow12(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow12(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow12();
         }

      }

      protected void GXRefreshCommand12( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V2H2 */
         E12V2H2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2H2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV8pMidTip = A35MidTipo ;
         AV9pCatCod = A32CatCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer12( )
      {
         subwgx00b012 oAux = subwgx00b012 ;
         subwgx00b012 = new subwgx00b012 ();
         variablesToSubfile12 ();
         subGrd_1.addElement(subwgx00b012);
         subwgx00b012 = oAux;
      }

      private void E11V2H2( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors12( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 598 , 306 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         cmbavCmidtipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 210 , 24 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cMidTip" );
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbavCmidtipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbavCmidtipo.addFocusListener(this);
         cmbavCmidtipo.addItemListener(this);
         cmbavCmidtipo.getGXComponent().setHelpId("HLP_WGx00B0.htm");
         edtavCcatcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),210, 48, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 210 , 48 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cCatCod" );
         ((GXEdit) edtavCcatcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCcatcodigo.addFocusListener(this);
         edtavCcatcodigo.getGXComponent().setHelpId("HLP_WGx00B0.htm");
         edtavCconftipvalor = new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),210, 72, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 210 , 72 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7cConfTi" );
         ((GXEdit) edtavCconftipvalor.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCconftipvalor.addFocusListener(this);
         edtavCconftipvalor.getGXComponent().setHelpId("HLP_WGx00B0.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx00B0_load12(this), new Gx00B0_flow12(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectShort ( new GXComboBox(GXPanel1, false) , null ,  0 , 0 , 87 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A35MidTipo" ), "Tipo da mídia"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 87 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 172, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 171 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A32CatCodi" ), "Código da categoria do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 171 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 135, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 134 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A85ConfTip" ), "Valor da configuração"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 134 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 96 , 451 , 193 ,  18 ));
         ((GXComboBox) subGrd_1.getColumn(0).getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) subGrd_1.getColumn(0).getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) subGrd_1.getColumn(0).getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) subGrd_1.getColumn(0).getGXComponent()).addItem( new java.lang.Short(4),"Box");
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  490 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  490 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  490 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  490 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Tipo da mídia", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 79 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código da categoria do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 163 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Valor da configuração", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 72 , 126 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   cmbavCmidtipo ,
                   edtavCcatcodigo ,
                   edtavCconftipvalor ,
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

      protected void variablesToSubfile12( )
      {
         subwgx00b012.setMidTipo(A35MidTipo);
         subwgx00b012.setCatCodigo(A32CatCodi);
         subwgx00b012.setConfTipValor(A85ConfTip);
      }

      protected void subfileToVariables12( )
      {
         A35MidTipo = subwgx00b012.getMidTipo();
         A32CatCodi = subwgx00b012.getCatCodigo();
         A85ConfTip = subwgx00b012.getConfTipValor();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         cmbavCmidtipo.setValue( AV5cMidTip );
         edtavCcatcodigo.setValue( AV6cCatCod );
         edtavCconftipvalor.setValue( AV7cConfTi );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cMidTip = (short)(cmbavCmidtipo.getValue()) ;
         cmbavCmidtipo.setValue(AV5cMidTip);
         AV6cCatCod = (int)(edtavCcatcodigo.getValue()) ;
         edtavCcatcodigo.setValue(AV6cCatCod);
         AV7cConfTi = (decimal)(edtavCconftipvalor.getValue()) ;
         edtavCconftipvalor.setValue(AV7cConfTi);
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
            subwgx00b012 = ( subwgx00b012 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00b012 = new subwgx00b012 ();
         }
         subfileToVariables12 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile12 ();
         subGrd_1.refreshLineValue(subwgx00b012);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx00b012 = ( subwgx00b012 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00b012 = new subwgx00b012 ();
         }
         subfileToVariables12 ();
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
            /* Execute user event: E12V2H2 */
            E12V2H2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2H2 */
            E12V2H2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( cmbavCmidtipo.isEventSource(eventSource) ) {
            setGXCursor( cmbavCmidtipo.getGXCursor() );
            return;
         }
         if ( edtavCcatcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCcatcodigo.getGXCursor() );
            return;
         }
         if ( edtavCconftipvalor.isEventSource(eventSource) ) {
            setGXCursor( edtavCconftipvalor.getGXCursor() );
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
         if ( cmbavCmidtipo.isEventSource(eventSource) ) {
            AV5cMidTip = cmbavCmidtipo.getValue() ;
            return;
         }
         if ( edtavCcatcodigo.isEventSource(eventSource) ) {
            AV6cCatCod = edtavCcatcodigo.getValue() ;
            return;
         }
         if ( edtavCconftipvalor.isEventSource(eventSource) ) {
            AV7cConfTi = edtavCconftipvalor.getValue() ;
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
            /* Execute user event: E12V2H2 */
            E12V2H2 ();
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
         this.AV8pMidTip = AV8pMidTip;
         this.AV9pCatCod = AV9pCatCod;
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
         subwgx00b012 = new subwgx00b012();
         scmdbuf = "" ;
         AV5cMidTip = 0 ;
         AV6cCatCod = 0 ;
         AV7cConfTi = (decimal)(0M) ;
         W002H2_A85ConfTip = new decimal[1] ;
         W002H2_n85ConfTip = new bool[] {false} ;
         W002H2_A32CatCodi = new int[1] ;
         W002H2_A35MidTipo = new short[1] ;
         A85ConfTip = (decimal)(0M) ;
         n85ConfTip = false ;
         A32CatCodi = 0 ;
         A35MidTipo = 0 ;
         gxIsRefreshing = false ;
         cV5cMidTip = 0 ;
         cV6cCatCod = 0 ;
         cV7cConfTi = (decimal)(0M) ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx00b0__default(),
            new Object[][] {
                new Object[] {
               W002H2_A85ConfTip, W002H2_n85ConfTip, W002H2_A32CatCodi, W002H2_A35MidTipo
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV5cMidTip ;
      protected short A35MidTipo ;
      protected short cV5cMidTip ;
      protected short AV8pMidTip ;
      protected int AV6cCatCod ;
      protected int A32CatCodi ;
      protected int cV6cCatCod ;
      protected int AV9pCatCod ;
      protected decimal AV7cConfTi ;
      protected decimal A85ConfTip ;
      protected decimal cV7cConfTi ;
      protected String scmdbuf ;
      protected bool n85ConfTip ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx00b012 subwgx00b012 ;
      protected IDataReader W002H2 ;
      protected IDataStoreProvider pr_default ;
      protected decimal[] W002H2_A85ConfTip ;
      protected bool[] W002H2_n85ConfTip ;
      protected int[] W002H2_A32CatCodi ;
      protected short[] W002H2_A35MidTipo ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectShort cmbavCmidtipo ;
      protected GUIObjectInt edtavCcatcodigo ;
      protected GUIObjectDecimal2 edtavCconftipvalor ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected ILabel lbllbl11 ;
      protected short aP0_pMidTipo ;
      protected int aP1_pCatCodigo ;
   }

   public class wgx00b0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW002H2 ;
          prmW002H2 = new Object[] {
          new Object[] {"@AV5cMidTip",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV6cCatCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV7cConfTi",SqlDbType.Decimal,12,2}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002H2", "SELECT [ConfTipValor], [CatCodigo], [MidTipo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE ([MidTipo] >= @AV5cMidTip and [CatCodigo] >= @AV6cCatCod) AND ([ConfTipValor] >= @AV7cConfTi) ORDER BY [MidTipo], [CatCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002H2,9,0,true,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                break;
       }
    }

 }

}
