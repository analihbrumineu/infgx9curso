/*
               File: Gx0051
        Description: Lista de Seleção Elenco do filme
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:14.70
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
   public class wgx0051 : GXWorkpanel
   {
      public wgx0051( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx0051( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx0051( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx0051" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Elenco do filme" ;
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
         return 425 ;
      }

      public override int getFrmHeight( )
      {
         return 306 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx0051.htm";
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

      public void execute( int aP0_FilCodigo ,
                           out int aP1_pFilAtoCodigo )
      {
         this.A28FilCodi = aP0_FilCodigo;
         this.AV7pFilAto = 0 ;
         executePrivate();
         aP1_pFilAtoCodigo=this.AV7pFilAto;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load11( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx005111 = new subwgx005111 ();
         /* Using cursor W002C2 */
         pr_default.execute(0, new Object[] {A28FilCodi, AV5cFilAto, AV6cFilAto});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A81FilAtoP = W002C2_A81FilAtoP[0] ;
            n81FilAtoP = W002C2_n81FilAtoP[0] ;
            A77FilAtoC = W002C2_A77FilAtoC[0] ;
            /* Execute user event: E11V2C2 */
            E11V2C2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx0051_load11 : GXLoadProducer
      {
         wgx0051 _sf ;

         public Gx0051_load11( wgx0051 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer11();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load11();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors11();
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

      public bool isLoadAtStartup_flow11( )
      {
         return true;
      }

      public void autoRefresh_flow11( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cFilAto!=cV5cFilAto)||(AV6cFilAto!=cV6cFilAto) ) || (!loadedFirstTime && ! isLoadAtStartup_flow11() )) {
            subfile.refresh();
            resetSubfileConditions_flow11() ;
         }
      }

      public bool getSearch_flow11( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow11( )
      {
         cV5cFilAto = AV5cFilAto ;
         cV6cFilAto = AV6cFilAto ;
      }

      public void resetSearchConditions_flow11( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow11( )
      {
         return new subwgx005111 ();
      }

      public bool getSearch_flow11( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow11( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow11( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow11( )
      {
         GXRefreshCommand11 ();
      }

      public class Gx0051_flow11 : GXSubfileFlow
      {
         wgx0051 _sf ;

         public Gx0051_flow11( wgx0051 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow11();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow11(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow11();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow11();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow11(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow11();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow11(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow11(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow11(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow11();
         }

      }

      protected void GXRefreshCommand11( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V2C2 */
         E12V2C2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2C2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV7pFilAto = A77FilAtoC ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer11( )
      {
         subwgx005111 oAux = subwgx005111 ;
         subwgx005111 = new subwgx005111 ();
         variablesToSubfile11 ();
         subGrd_1.addElement(subwgx005111);
         subwgx005111 = oAux;
      }

      private void E11V2C2( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors11( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 425 , 306 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtFilCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),189, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 189 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" );
         ((GXEdit) edtFilCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtFilCodigo.addFocusListener(this);
         edtFilCodigo.getGXComponent().setHelpId("HLP_WGx0051.htm");
         edtavCfilatocodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),189, 48, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 189 , 48 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cFilAto" );
         ((GXEdit) edtavCfilatocodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCfilatocodigo.addFocusListener(this);
         edtavCfilatocodigo.getGXComponent().setHelpId("HLP_WGx0051.htm");
         chkavCfilatoprot = new GUIObjectShort ( new GXCheckBox(GXPanel1, "Protagonista" , new java.lang.Short(1), new java.lang.Short(0)) , GXPanel1 , 189 , 72 , 105 , 16 , Integer.MAX_VALUE , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cFilAto" );
         chkavCfilatoprot.addFocusListener(this);
         chkavCfilatoprot.addItemListener(this);
         chkavCfilatoprot.getGXComponent().setHelpId("HLP_WGx0051.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx0051_load11(this), new Gx0051_flow11(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 141, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 140 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A77FilAtoC" ), "Código do ator do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 140 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectShort ( new GXCheckBox(GXPanel1, "" , new java.lang.Short(1), new java.lang.Short(0)) , null ,  0 , 0 , 80 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A81FilAtoP" ), "Protagonista"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 80 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 96 , 278 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  317 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  317 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  317 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  317 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 88 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código do ator do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 132 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtFilCodigo ,
                   edtavCfilatocodigo ,
                   chkavCfilatoprot ,
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

      protected void variablesToSubfile11( )
      {
         subwgx005111.setFilAtoCodigo(A77FilAtoC);
         subwgx005111.setFilAtoProt(A81FilAtoP);
         subwgx005111.setFilCodigo(A28FilCodi);
      }

      protected void subfileToVariables11( )
      {
         A77FilAtoC = subwgx005111.getFilAtoCodigo();
         A81FilAtoP = subwgx005111.getFilAtoProt();
         A28FilCodi = subwgx005111.getFilCodigo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtFilCodigo.setValue( A28FilCodi );
         edtavCfilatocodigo.setValue( AV5cFilAto );
         chkavCfilatoprot.setValue( AV6cFilAto );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A28FilCodi = (int)(edtFilCodigo.getValue()) ;
         edtFilCodigo.setValue(A28FilCodi);
         AV5cFilAto = (int)(edtavCfilatocodigo.getValue()) ;
         edtavCfilatocodigo.setValue(AV5cFilAto);
         AV6cFilAto = (short)(chkavCfilatoprot.getValue()) ;
         chkavCfilatoprot.setValue(AV6cFilAto);
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
            subwgx005111 = ( subwgx005111 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx005111 = new subwgx005111 ();
         }
         subfileToVariables11 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile11 ();
         subGrd_1.refreshLineValue(subwgx005111);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx005111 = ( subwgx005111 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx005111 = new subwgx005111 ();
         }
         subfileToVariables11 ();
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
            /* Execute user event: E12V2C2 */
            E12V2C2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2C2 */
            E12V2C2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtFilCodigo.getGXCursor() );
            return;
         }
         if ( edtavCfilatocodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCfilatocodigo.getGXCursor() );
            return;
         }
         if ( chkavCfilatoprot.isEventSource(eventSource) ) {
            setGXCursor( chkavCfilatoprot.getGXCursor() );
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
         if ( edtFilCodigo.isEventSource(eventSource) ) {
            A28FilCodi = edtFilCodigo.getValue() ;
            return;
         }
         if ( edtavCfilatocodigo.isEventSource(eventSource) ) {
            AV5cFilAto = edtavCfilatocodigo.getValue() ;
            return;
         }
         if ( chkavCfilatoprot.isEventSource(eventSource) ) {
            AV6cFilAto = chkavCfilatoprot.getValue() ;
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
            /* Execute user event: E12V2C2 */
            E12V2C2 ();
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
         this.AV7pFilAto = AV7pFilAto;
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
         subwgx005111 = new subwgx005111();
         scmdbuf = "" ;
         AV5cFilAto = 0 ;
         AV6cFilAto = 0 ;
         W002C2_A28FilCodi = new int[1] ;
         W002C2_A81FilAtoP = new short[1] ;
         W002C2_n81FilAtoP = new bool[] {false} ;
         W002C2_A77FilAtoC = new int[1] ;
         A81FilAtoP = 0 ;
         n81FilAtoP = false ;
         A77FilAtoC = 0 ;
         gxIsRefreshing = false ;
         cV5cFilAto = 0 ;
         cV6cFilAto = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx0051__default(),
            new Object[][] {
                new Object[] {
               W002C2_A28FilCodi, W002C2_A81FilAtoP, W002C2_n81FilAtoP, W002C2_A77FilAtoC
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV6cFilAto ;
      protected short A81FilAtoP ;
      protected short cV6cFilAto ;
      protected int A28FilCodi ;
      protected int AV5cFilAto ;
      protected int A77FilAtoC ;
      protected int cV5cFilAto ;
      protected int AV7pFilAto ;
      protected String scmdbuf ;
      protected bool n81FilAtoP ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx005111 subwgx005111 ;
      protected IDataReader W002C2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W002C2_A28FilCodi ;
      protected short[] W002C2_A81FilAtoP ;
      protected bool[] W002C2_n81FilAtoP ;
      protected int[] W002C2_A77FilAtoC ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtFilCodigo ;
      protected GUIObjectInt edtavCfilatocodigo ;
      protected GUIObjectShort chkavCfilatoprot ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected int aP1_pFilAtoCodigo ;
   }

   public class wgx0051__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW002C2 ;
          prmW002C2 = new Object[] {
          new Object[] {"@FilCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5cFilAto",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cFilAto",SqlDbType.SmallInt,1,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002C2", "SELECT [FilCodigo], [FilAtoProt], [FilAtoCodigo] FROM [FILMEELENCO] WITH (NOLOCK) WHERE ([FilCodigo] = @FilCodigo and [FilAtoCodigo] >= @AV5cFilAto) AND ([FilAtoProt] >= @AV6cFilAto) ORDER BY [FilCodigo], [FilAtoCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002C2,9,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
