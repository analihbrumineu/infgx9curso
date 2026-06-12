/*
               File: ConsCidade
        Description: Consulta de cidades.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 11:52:36.59
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
   public class wconscidade : GXWorkpanel
   {
      public wconscidade( int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconscidade( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconscidade( IGxContext context ,
                          int hnd ,
                          ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsCidade" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de cidades" ;
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
         return 682 ;
      }

      public override int getFrmHeight( )
      {
         return 832 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsCidade.htm";
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

      public void execute( out int aP0_CidCodigoRet )
      {
         this.AV5CidCodi = 0 ;
         executePrivate();
         aP0_CidCodigoRet=this.AV5CidCodi;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load02( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconscidade02 = new subwconscidade02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV6EstUF ,
                                              AV8CidCodi ,
                                              AV7CidNome ,
                                              A25EstUF ,
                                              A26CidCodi ,
                                              A27CidNome },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000I2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A24EstCodi = W000I2_A24EstCodi[0] ;
            n24EstCodi = W000I2_n24EstCodi[0] ;
            A27CidNome = W000I2_A27CidNome[0] ;
            n27CidNome = W000I2_n27CidNome[0] ;
            A25EstUF = W000I2_A25EstUF[0] ;
            n25EstUF = W000I2_n25EstUF[0] ;
            A26CidCodi = W000I2_A26CidCodi[0] ;
            A25EstUF = W000I2_A25EstUF[0] ;
            n25EstUF = W000I2_n25EstUF[0] ;
            /* Execute user event: E11V0I2 */
            E11V0I2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsCidade_load02 : GXLoadProducer
      {
         wconscidade _sf ;

         public ConsCidade_load02( wconscidade uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer02();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load02();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors02();
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
            subGxsf2.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow02( )
      {
         return true;
      }

      public void autoRefresh_flow02( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow02() )) {
            subfile.refresh();
            resetSubfileConditions_flow02() ;
         }
      }

      public bool getSearch_flow02( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow02( )
      {
      }

      public void resetSearchConditions_flow02( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow02( )
      {
         return new subwconscidade02 ();
      }

      public bool getSearch_flow02( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow02( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow02( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow02( )
      {
         GXRefreshCommand02 ();
      }

      public class ConsCidade_flow02 : GXSubfileFlow
      {
         wconscidade _sf ;

         public ConsCidade_flow02( wconscidade uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow02();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow02(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow02();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow02();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow02(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow02();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow02(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow02(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow02(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow02();
         }

      }

      protected void GXRefreshCommand02( )
      {
         ControlsToVariables();
         /* Execute user event: E12V0I2 */
         E12V0I2 ();
         /* End function GeneXus Refresh */
      }

      protected void E12V0I2( )
      {
         /* Refresh Routine */
         if ( ( AV8CidCodi < 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
      }

      public override void GXExit( )
      {
         /* Execute user event: E13V0I2 */
         E13V0I2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E13V0I2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV5CidCodi = A26CidCodi ;
      }

      protected void E14V0I2( )
      {
         eventLevelContext();
         /* CidCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E15V0I2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A26CidCodi") )
         {
            new wconscidade(context, base.remoteHandle, base.context).execute( out  A26CidCodi) ;
            ((subwconscidade02)subGxsf2.getCurrentElement()).setCidCodigo(A26CidCodi);
            subGxsf2.refreshLineValue(subGxsf2.getSelectedElement());
            subGxsf2.repaint();
         }
         eventLevelResetContext();
      }

      public void loadToBuffer02( )
      {
         subwconscidade02 oAux = subwconscidade02 ;
         subwconscidade02 = new subwconscidade02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwconscidade02);
         subwconscidade02 = oAux;
      }

      private void E11V0I2( )
      {
         /* Load Routine */
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 682 , 832 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 83, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 83 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8CidCodi" );
         ((GXEdit) edtavCidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCidcodigo.addFocusListener(this);
         edtavCidcodigo.getGXComponent().setHelpId("HLP_WConsCidade.htm");
         edtavEstuf = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),159, 83, 24, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 159 , 83 , 24 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6EstUF" );
         ((GXEdit) edtavEstuf.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavEstuf.addFocusListener(this);
         edtavEstuf.getGXComponent().setHelpId("HLP_WConsCidade.htm");
         edtavCidnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),205, 83, 238, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 205 , 83 , 238 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7CidNome" );
         ((GXEdit) edtavCidnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCidnome.addFocusListener(this);
         edtavCidnome.getGXComponent().setHelpId("HLP_WConsCidade.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new ConsCidade_load02(this), new ConsCidade_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 72, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 71 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A26CidCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 71 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),0, 0, 39, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.CHAR, false, false, 0, false) , null ,  0 , 0 , 38 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" ), "UF"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 38 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 211, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 210 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A27CidNome" ), "Cidade"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 210 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 37 , 18 , GXPanel1 , 65 , 114 , 378 , 694 ,  18 ));
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         subGxsf2.getColumn(0).addActionListener( this);
         subGxsf2.getColumn(0).addItemListener( this);
         lbllbl8 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl6 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 159 , 65 , 17 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "Cidade", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 205 , 65 , 40 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCidcodigo ,
                   edtavEstuf ,
                   edtavCidnome ,
                   subGxsf2
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf2, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile02( )
      {
         subwconscidade02.setCidCodigo(A26CidCodi);
         subwconscidade02.setEstUF(A25EstUF);
         subwconscidade02.setCidNome(A27CidNome);
      }

      protected void subfileToVariables02( )
      {
         A26CidCodi = subwconscidade02.getCidCodigo();
         A25EstUF = subwconscidade02.getEstUF();
         A27CidNome = subwconscidade02.getCidNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavEstuf.setValue( AV6EstUF );
         edtavCidcodigo.setValue( AV8CidCodi );
         edtavCidnome.setValue( AV7CidNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV6EstUF = (String)(edtavEstuf.getValue()) ;
         edtavEstuf.setValue(AV6EstUF);
         AV8CidCodi = (int)(edtavCidcodigo.getValue()) ;
         edtavCidcodigo.setValue(AV8CidCodi);
         AV7CidNome = (String)(edtavCidnome.getValue()) ;
         edtavCidnome.setValue(AV7CidNome);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf2.inValidElement() )
         {
            subwconscidade02 = ( subwconscidade02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwconscidade02 = new subwconscidade02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwconscidade02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwconscidade02 = ( subwconscidade02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwconscidade02 = new subwconscidade02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E14V0I2 */
            E14V0I2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavEstuf.isEventSource(eventSource) ) {
            setGXCursor( edtavEstuf.getGXCursor() );
            return;
         }
         if ( edtavCidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCidcodigo.getGXCursor() );
            return;
         }
         if ( edtavCidnome.isEventSource(eventSource) ) {
            setGXCursor( edtavCidnome.getGXCursor() );
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
         if ( edtavEstuf.isEventSource(eventSource) ) {
            AV6EstUF = edtavEstuf.getValue() ;
            return;
         }
         if ( edtavCidcodigo.isEventSource(eventSource) ) {
            AV8CidCodi = edtavCidcodigo.getValue() ;
            return;
         }
         if ( edtavCidnome.isEventSource(eventSource) ) {
            AV7CidNome = edtavCidnome.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0I2 */
            E14V0I2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E15V0I2 */
            E15V0I2 ();
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
            /* Execute user event: E13V0I2 */
            E13V0I2 ();
         }
         this.AV5CidCodi = AV5CidCodi;
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
         subwconscidade02 = new subwconscidade02();
         scmdbuf = "" ;
         AV6EstUF = "" ;
         AV8CidCodi = 0 ;
         AV7CidNome = "" ;
         A25EstUF = "" ;
         A26CidCodi = 0 ;
         A27CidNome = "" ;
         W000I2_A24EstCodi = new int[1] ;
         W000I2_n24EstCodi = new bool[] {false} ;
         W000I2_A27CidNome = new String[] {""} ;
         W000I2_n27CidNome = new bool[] {false} ;
         W000I2_A25EstUF = new String[] {""} ;
         W000I2_n25EstUF = new bool[] {false} ;
         W000I2_A26CidCodi = new int[1] ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         n27CidNome = false ;
         n25EstUF = false ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconscidade__default(),
            new Object[][] {
                new Object[] {
               W000I2_A24EstCodi, W000I2_n24EstCodi, W000I2_A27CidNome, W000I2_n27CidNome, W000I2_A25EstUF, W000I2_n25EstUF, W000I2_A26CidCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV8CidCodi ;
      protected int A26CidCodi ;
      protected int A24EstCodi ;
      protected int AV5CidCodi ;
      protected String scmdbuf ;
      protected String AV6EstUF ;
      protected String A25EstUF ;
      protected bool n24EstCodi ;
      protected bool n27CidNome ;
      protected bool n25EstUF ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV7CidNome ;
      protected String A27CidNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconscidade02 subwconscidade02 ;
      protected IDataReader W000I2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W000I2_A24EstCodi ;
      protected bool[] W000I2_n24EstCodi ;
      protected String[] W000I2_A27CidNome ;
      protected bool[] W000I2_n27CidNome ;
      protected String[] W000I2_A25EstUF ;
      protected bool[] W000I2_n25EstUF ;
      protected int[] W000I2_A26CidCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCidcodigo ;
      protected GUIObjectString edtavEstuf ;
      protected GUIObjectString edtavCidnome ;
      protected GXSubfile subGxsf2 ;
      protected ILabel lbllbl8 ;
      protected ILabel lbllbl6 ;
      protected ILabel lbllbl10 ;
      protected int aP0_CidCodigoRet ;
   }

   public class wconscidade__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000I2( String AV6EstUF ,
                                           int AV8CidCodi ,
                                           String AV7CidNome ,
                                           String A25EstUF ,
                                           int A26CidCodi ,
                                           String A27CidNome )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT T1.[EstCodigo], T1.[CidNome], T2.[EstUF], T1.[CidCodigo] FROM ([CIDADE] T1 WITH (NOLOCK) LEFT JOIN [ESTADO] T2 WITH (NOLOCK) ON T2.[EstCodigo] = T1.[EstCodigo])" ;
         sWhereString = "" ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6EstUF).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T2.[EstUF] = '" + StringUtil.RTrim( StringUtil.StringReplace( AV6EstUF, "'", "''")) + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T2.[EstUF] = '" + StringUtil.RTrim( StringUtil.StringReplace( AV6EstUF, "'", "''")) + "')" ;
            }
         }
         if ( ( AV8CidCodi != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[CidCodigo] = " + StringUtil.Str( (decimal)(AV8CidCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[CidCodigo] = " + StringUtil.Str( (decimal)(AV8CidCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7CidNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and (T1.[CidNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CidNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[CidNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CidNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[CidCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000I2( (String)dynConstraints[0] , (int)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (int)dynConstraints[4] , (String)dynConstraints[5] );
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
          Object[] prmW000I2 ;
          prmW000I2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000I2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000I2,30,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 2) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((int[]) buf[6])[0] = rslt.getInt(4) ;
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
