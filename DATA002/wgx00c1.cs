/*
               File: Gx00C1
        Description: Lista de Seleção Configurações tipo de mídia.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 5/26/2026 9:33:37.74
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
   public class wgx00c1 : GXWorkpanel
   {
      public wgx00c1( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx00c1( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx00c1( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx00C1" ;
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
         return 510 ;
      }

      public override int getFrmHeight( )
      {
         return 306 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx00C1.htm";
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

      public void execute( short aP0_MidTipo ,
                           out int aP1_pCatCodigo )
      {
         this.A35MidTipo = aP0_MidTipo;
         this.AV7pCatCod = 0 ;
         executePrivate();
         aP1_pCatCodigo=this.AV7pCatCod;
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
         subwgx00c112 = new subwgx00c112 ();
         /* Using cursor W001V2 */
         pr_default.execute(0, new Object[] {A35MidTipo, AV5cCatCod, AV6cConfTi});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A85ConfTip = W001V2_A85ConfTip[0] ;
            n85ConfTip = W001V2_n85ConfTip[0] ;
            A32CatCodi = W001V2_A32CatCodi[0] ;
            /* Execute user event: E11V1V2 */
            E11V1V2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx00C1_load12 : GXLoadProducer
      {
         wgx00c1 _sf ;

         public Gx00C1_load12( wgx00c1 uType ) : base()
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
         if (( (AV5cCatCod!=cV5cCatCod)||(AV6cConfTi!=cV6cConfTi) ) || (!loadedFirstTime && ! isLoadAtStartup_flow12() )) {
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
         cV5cCatCod = AV5cCatCod ;
         cV6cConfTi = AV6cConfTi ;
      }

      public void resetSearchConditions_flow12( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow12( )
      {
         return new subwgx00c112 ();
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

      public class Gx00C1_flow12 : GXSubfileFlow
      {
         wgx00c1 _sf ;

         public Gx00C1_flow12( wgx00c1 uType ) : base()
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
         /* Execute user event: E12V1V2 */
         E12V1V2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V1V2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV7pCatCod = A32CatCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer12( )
      {
         subwgx00c112 oAux = subwgx00c112 ;
         subwgx00c112 = new subwgx00c112 ();
         variablesToSubfile12 ();
         subGrd_1.addElement(subwgx00c112);
         subwgx00c112 = oAux;
      }

      private void E11V1V2( )
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
         GXPanel1 = new GXPanel(this, 0 , 0 , 510 , 306 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         cmbMidTipo = new GUIObjectShort ( new GXComboBox(GXPanel1) , GXPanel1 , 210 , 24 , 68 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A35MidTipo" );
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(1),"DVD");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(2),"Bluray");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(3),"VHS");
         ((GXComboBox) cmbMidTipo.getGXComponent()).addItem( new java.lang.Short(4),"Box");
         cmbMidTipo.addFocusListener(this);
         cmbMidTipo.addItemListener(this);
         cmbMidTipo.getGXComponent().setHelpId("HLP_WGx00C1.htm");
         edtavCcatcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),210, 48, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 210 , 48 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cCatCod" );
         ((GXEdit) edtavCcatcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCcatcodigo.addFocusListener(this);
         edtavCcatcodigo.getGXComponent().setHelpId("HLP_WGx00C1.htm");
         edtavCconftipvalor = new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),210, 72, 108, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 210 , 72 , 108 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cConfTi" );
         ((GXEdit) edtavCconftipvalor.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCconftipvalor.addFocusListener(this);
         edtavCconftipvalor.getGXComponent().setHelpId("HLP_WGx00C1.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx00C1_load12(this), new Gx00C1_flow12(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 172, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 171 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A32CatCodi" ), "Código da categoria do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 171 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDecimal2 ( new GXEdit(12, "ZZZ,ZZZ,ZZ9.99", UIFactory.getFont( "Courier New", 0, 9),0, 0, 135, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 134 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A85ConfTip" ), "Valor da configuração"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 134 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 96 , 363 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  402 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  402 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  402 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  402 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Tipo da mídia.", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 83 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código da categoria do filme.", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 167 , 13 );
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Valor da configuração", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 72 , 126 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   cmbMidTipo ,
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
         subwgx00c112.setCatCodigo(A32CatCodi);
         subwgx00c112.setConfTipValor(A85ConfTip);
         subwgx00c112.setMidTipo(A35MidTipo);
      }

      protected void subfileToVariables12( )
      {
         A32CatCodi = subwgx00c112.getCatCodigo();
         A85ConfTip = subwgx00c112.getConfTipValor();
         A35MidTipo = subwgx00c112.getMidTipo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         cmbMidTipo.setValue( A35MidTipo );
         edtavCcatcodigo.setValue( AV5cCatCod );
         edtavCconftipvalor.setValue( AV6cConfTi );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A35MidTipo = (short)(cmbMidTipo.getValue()) ;
         cmbMidTipo.setValue(A35MidTipo);
         AV5cCatCod = (int)(edtavCcatcodigo.getValue()) ;
         edtavCcatcodigo.setValue(AV5cCatCod);
         AV6cConfTi = (decimal)(edtavCconftipvalor.getValue()) ;
         edtavCconftipvalor.setValue(AV6cConfTi);
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
            subwgx00c112 = ( subwgx00c112 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00c112 = new subwgx00c112 ();
         }
         subfileToVariables12 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile12 ();
         subGrd_1.refreshLineValue(subwgx00c112);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx00c112 = ( subwgx00c112 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00c112 = new subwgx00c112 ();
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
            /* Execute user event: E12V1V2 */
            E12V1V2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V1V2 */
            E12V1V2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            setGXCursor( cmbMidTipo.getGXCursor() );
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
         if ( cmbMidTipo.isEventSource(eventSource) ) {
            A35MidTipo = cmbMidTipo.getValue() ;
            return;
         }
         if ( edtavCcatcodigo.isEventSource(eventSource) ) {
            AV5cCatCod = edtavCcatcodigo.getValue() ;
            return;
         }
         if ( edtavCconftipvalor.isEventSource(eventSource) ) {
            AV6cConfTi = edtavCconftipvalor.getValue() ;
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
            /* Execute user event: E12V1V2 */
            E12V1V2 ();
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
         this.AV7pCatCod = AV7pCatCod;
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
         subwgx00c112 = new subwgx00c112();
         scmdbuf = "" ;
         AV5cCatCod = 0 ;
         AV6cConfTi = (decimal)(0M) ;
         W001V2_A35MidTipo = new short[1] ;
         W001V2_A85ConfTip = new decimal[1] ;
         W001V2_n85ConfTip = new bool[] {false} ;
         W001V2_A32CatCodi = new int[1] ;
         A85ConfTip = (decimal)(0M) ;
         n85ConfTip = false ;
         A32CatCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cCatCod = 0 ;
         cV6cConfTi = (decimal)(0M) ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx00c1__default(),
            new Object[][] {
                new Object[] {
               W001V2_A35MidTipo, W001V2_A85ConfTip, W001V2_n85ConfTip, W001V2_A32CatCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short A35MidTipo ;
      protected int AV5cCatCod ;
      protected int A32CatCodi ;
      protected int cV5cCatCod ;
      protected int AV7pCatCod ;
      protected decimal AV6cConfTi ;
      protected decimal A85ConfTip ;
      protected decimal cV6cConfTi ;
      protected String scmdbuf ;
      protected bool n85ConfTip ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx00c112 subwgx00c112 ;
      protected IDataReader W001V2 ;
      protected IDataStoreProvider pr_default ;
      protected short[] W001V2_A35MidTipo ;
      protected decimal[] W001V2_A85ConfTip ;
      protected bool[] W001V2_n85ConfTip ;
      protected int[] W001V2_A32CatCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectShort cmbMidTipo ;
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
      protected int aP1_pCatCodigo ;
   }

   public class wgx00c1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW001V2 ;
          prmW001V2 = new Object[] {
          new Object[] {"@MidTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV5cCatCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cConfTi",SqlDbType.Decimal,12,2}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W001V2", "SELECT [MidTipo], [ConfTipValor], [CatCodigo] FROM [CONFTIPMIDIA] WITH (NOLOCK) WHERE ([MidTipo] = @MidTipo and [CatCodigo] >= @AV5cCatCod) AND ([ConfTipValor] >= @AV6cConfTi) ORDER BY [MidTipo], [CatCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW001V2,9,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
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
