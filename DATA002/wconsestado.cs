/*
               File: ConsEstado
        Description: Consulta de Estados.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 11:31:33.41
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
   public class wconsestado : GXWorkpanel
   {
      public wconsestado( int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconsestado( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconsestado( IGxContext context ,
                          int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsEstado" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de Estados" ;
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
         return 557 ;
      }

      public override int getFrmHeight( )
      {
         return 845 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsEstado.htm";
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

      public void execute( out int aP0_EstCodigoRet )
      {
         this.AV8EstCodi = 0 ;
         executePrivate();
         aP0_EstCodigoRet=this.AV8EstCodi;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load08( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconsestado08 = new subwconsestado08 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV7EstUF ,
                                              AV5EstCodi ,
                                              AV6EstNome ,
                                              A25EstUF ,
                                              A24EstCodi ,
                                              A12EstNome },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000K2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf8.getSize() < 10000 ) ) )
         {
            A12EstNome = W000K2_A12EstNome[0] ;
            n12EstNome = W000K2_n12EstNome[0] ;
            A25EstUF = W000K2_A25EstUF[0] ;
            n25EstUF = W000K2_n25EstUF[0] ;
            A24EstCodi = W000K2_A24EstCodi[0] ;
            /* Execute user event: E11V0K2 */
            E11V0K2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf8.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsEstado_load08 : GXLoadProducer
      {
         wconsestado _sf ;

         public ConsEstado_load08( wconsestado uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer08();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load08();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors08();
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
            subGxsf8.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow08( )
      {
         return true;
      }

      public void autoRefresh_flow08( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow08() )) {
            subfile.refresh();
            resetSubfileConditions_flow08() ;
         }
      }

      public bool getSearch_flow08( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow08( )
      {
      }

      public void resetSearchConditions_flow08( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow08( )
      {
         return new subwconsestado08 ();
      }

      public bool getSearch_flow08( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow08( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow08( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow08( )
      {
         GXRefreshCommand08 ();
      }

      public class ConsEstado_flow08 : GXSubfileFlow
      {
         wconsestado _sf ;

         public ConsEstado_flow08( wconsestado uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow08();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow08(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow08();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow08();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow08(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow08();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow08(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow08(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow08(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow08();
         }

      }

      protected void GXRefreshCommand08( )
      {
         ControlsToVariables();
         /* Execute user event: E12V0K2 */
         E12V0K2 ();
         /* End function GeneXus Refresh */
      }

      protected void E12V0K2( )
      {
         /* Refresh Routine */
         if ( ( AV5EstCodi < 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
      }

      public override void GXExit( )
      {
         /* Execute user event: E13V0K2 */
         E13V0K2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E13V0K2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV8EstCodi = A24EstCodi ;
      }

      protected void E14V0K2( )
      {
         eventLevelContext();
         /* EstCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E15V0K2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A24EstCodi") )
         {
            new wconsestado(context, base.remoteHandle, base.context).execute( out  A24EstCodi) ;
            ((subwconsestado08)subGxsf8.getCurrentElement()).setEstCodigo(A24EstCodi);
            subGxsf8.refreshLineValue(subGxsf8.getSelectedElement());
            subGxsf8.repaint();
         }
         eventLevelResetContext();
      }

      public void loadToBuffer08( )
      {
         subwconsestado08 oAux = subwconsestado08 ;
         subwconsestado08 = new subwconsestado08 ();
         variablesToSubfile08 ();
         subGxsf8.addElement(subwconsestado08);
         subwconsestado08 = oAux;
      }

      private void E11V0K2( )
      {
         /* Load Routine */
         subGxsf8.loadCommand();
      }

      protected void closeCursors08( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 557 , 845 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavEstcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 70, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 70 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5EstCodi" );
         ((GXEdit) edtavEstcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavEstcodigo.addFocusListener(this);
         edtavEstcodigo.getGXComponent().setHelpId("HLP_WConsEstado.htm");
         edtavEstuf = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),158, 70, 24, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 158 , 70 , 24 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7EstUF" );
         ((GXEdit) edtavEstuf.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavEstuf.addFocusListener(this);
         edtavEstuf.getGXComponent().setHelpId("HLP_WConsEstado.htm");
         edtavEstnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),203, 70, 249, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 203 , 70 , 249 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6EstNome" );
         ((GXEdit) edtavEstnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavEstnome.addFocusListener(this);
         edtavEstnome.getGXComponent().setHelpId("HLP_WConsEstado.htm");
         addSubfile ( subGxsf8  = new GXSubfile ( new ConsEstado_load08(this), new ConsEstado_flow08(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 79, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 78 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 78 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),0, 0, 53, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.CHAR, false, false, 0, false) , null ,  0 , 0 , 52 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" ), "UF"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 52 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 199, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 198 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A12EstNome" ), "Estado"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 198 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 39 , 18 , GXPanel1 , 65 , 100 , 387 , 732 ,  18 ));
         subGxsf8.addActionListener(this);
         subGxsf8.addFocusListener(this);
         subGxsf8.setSortOnClick(true);
         subGxsf8.getColumn(0).addActionListener( this);
         subGxsf8.getColumn(0).addItemListener( this);
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 52 , 40 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 158 , 52 , 17 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 203 , 52 , 40 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavEstcodigo ,
                   edtavEstuf ,
                   edtavEstnome ,
                   subGxsf8
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf8, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile08( )
      {
         subwconsestado08.setEstCodigo(A24EstCodi);
         subwconsestado08.setEstUF(A25EstUF);
         subwconsestado08.setEstNome(A12EstNome);
      }

      protected void subfileToVariables08( )
      {
         A24EstCodi = subwconsestado08.getEstCodigo();
         A25EstUF = subwconsestado08.getEstUF();
         A12EstNome = subwconsestado08.getEstNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavEstcodigo.setValue( AV5EstCodi );
         edtavEstuf.setValue( AV7EstUF );
         edtavEstnome.setValue( AV6EstNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5EstCodi = (int)(edtavEstcodigo.getValue()) ;
         edtavEstcodigo.setValue(AV5EstCodi);
         AV7EstUF = (String)(edtavEstuf.getValue()) ;
         edtavEstuf.setValue(AV7EstUF);
         AV6EstNome = (String)(edtavEstnome.getValue()) ;
         edtavEstnome.setValue(AV6EstNome);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf8.inValidElement() )
         {
            subwconsestado08 = ( subwconsestado08 ) subGxsf8.getCurrentElement() ;
         }
         else
         {
            subwconsestado08 = new subwconsestado08 ();
         }
         subfileToVariables08 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile08 ();
         subGxsf8.refreshLineValue(subwconsestado08);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf8.inValidElement() )
         {
            subwconsestado08 = ( subwconsestado08 ) subGxsf8.getCurrentElement() ;
         }
         else
         {
            subwconsestado08 = new subwconsestado08 ();
         }
         subfileToVariables08 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf8.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf8.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E14V0K2 */
            E14V0K2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavEstcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavEstcodigo.getGXCursor() );
            return;
         }
         if ( edtavEstuf.isEventSource(eventSource) ) {
            setGXCursor( edtavEstuf.getGXCursor() );
            return;
         }
         if ( edtavEstnome.isEventSource(eventSource) ) {
            setGXCursor( edtavEstnome.getGXCursor() );
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
         if ( edtavEstcodigo.isEventSource(eventSource) ) {
            AV5EstCodi = edtavEstcodigo.getValue() ;
            return;
         }
         if ( edtavEstuf.isEventSource(eventSource) ) {
            AV7EstUF = edtavEstuf.getValue() ;
            return;
         }
         if ( edtavEstnome.isEventSource(eventSource) ) {
            AV6EstNome = edtavEstnome.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf8.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0K2 */
            E14V0K2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E15V0K2 */
            E15V0K2 ();
            return true ;
         }
         if (triggerEventEnter(eventSource, keyCode)) {
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
            /* Execute user event: E13V0K2 */
            E13V0K2 ();
         }
         this.AV8EstCodi = AV8EstCodi;
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
         subwconsestado08 = new subwconsestado08();
         scmdbuf = "" ;
         AV7EstUF = "" ;
         AV5EstCodi = 0 ;
         AV6EstNome = "" ;
         A25EstUF = "" ;
         A24EstCodi = 0 ;
         A12EstNome = "" ;
         W000K2_A12EstNome = new String[] {""} ;
         W000K2_n12EstNome = new bool[] {false} ;
         W000K2_A25EstUF = new String[] {""} ;
         W000K2_n25EstUF = new bool[] {false} ;
         W000K2_A24EstCodi = new int[1] ;
         n12EstNome = false ;
         n25EstUF = false ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconsestado__default(),
            new Object[][] {
                new Object[] {
               W000K2_A12EstNome, W000K2_n12EstNome, W000K2_A25EstUF, W000K2_n25EstUF, W000K2_A24EstCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5EstCodi ;
      protected int A24EstCodi ;
      protected int AV8EstCodi ;
      protected String scmdbuf ;
      protected String AV7EstUF ;
      protected String A25EstUF ;
      protected bool n12EstNome ;
      protected bool n25EstUF ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV6EstNome ;
      protected String A12EstNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconsestado08 subwconsestado08 ;
      protected IDataReader W000K2 ;
      protected IDataStoreProvider pr_default ;
      protected String[] W000K2_A12EstNome ;
      protected bool[] W000K2_n12EstNome ;
      protected String[] W000K2_A25EstUF ;
      protected bool[] W000K2_n25EstUF ;
      protected int[] W000K2_A24EstCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavEstcodigo ;
      protected GUIObjectString edtavEstuf ;
      protected GUIObjectString edtavEstnome ;
      protected GXSubfile subGxsf8 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl6 ;
      protected int aP0_EstCodigoRet ;
   }

   public class wconsestado__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000K2( String AV7EstUF ,
                                           int AV5EstCodi ,
                                           String AV6EstNome ,
                                           String A25EstUF ,
                                           int A24EstCodi ,
                                           String A12EstNome )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [EstNome], [EstUF], [EstCodigo] FROM [ESTADO] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7EstUF).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.RTrim( StringUtil.StringReplace( AV7EstUF, "'", "''")) + "' = [EstUF])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.RTrim( StringUtil.StringReplace( AV7EstUF, "'", "''")) + "' = [EstUF])" ;
            }
         }
         if ( ( AV5EstCodi != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([EstCodigo] = " + StringUtil.Str( (decimal)(AV5EstCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([EstCodigo] = " + StringUtil.Str( (decimal)(AV5EstCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6EstNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ('" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6EstNome, "'", "''")), 50, "%") + "' like [EstNome])" ;
            }
            else
            {
               sWhereString = sWhereString + " ('" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6EstNome, "'", "''")), 50, "%") + "' like [EstNome])" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY [EstCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000K2( (String)dynConstraints[0] , (int)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmW000K2 ;
          prmW000K2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000K2,31,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getString(2, 2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((int[]) buf[4])[0] = rslt.getInt(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
