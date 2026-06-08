/*
               File: PeEstado
        Description: Cadastro de Estados.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:12.98
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
   public class wpeestado : GXWorkpanel
   {
      public wpeestado( int hnd ,
                        ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpeestado( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpeestado( IGxContext context ,
                        int hnd ,
                        ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeEstado" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de Estados." ;
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
         return 700 ;
      }

      public override int getFrmHeight( )
      {
         return 768 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeEstado.htm";
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

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( )
      {
         executePrivate();
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
         subwpeestado02 = new subwpeestado02 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV8EstNome ,
                                              AV7EstUF ,
                                              A12EstNome ,
                                              A25EstUF },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W00092 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf2.getSize() < 10000 ) ) )
         {
            A12EstNome = W00092_A12EstNome[0] ;
            n12EstNome = W00092_n12EstNome[0] ;
            A25EstUF = W00092_A25EstUF[0] ;
            n25EstUF = W00092_n25EstUF[0] ;
            A24EstCodi = W00092_A24EstCodi[0] ;
            /* Execute user event: E11V092 */
            E11V092 ();
            pr_default.readNext(0);
         }
         if ( subGxsf2.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeEstado_load02 : GXLoadProducer
      {
         wpeestado _sf ;

         public PeEstado_load02( wpeestado uType ) : base()
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
         return new subwpeestado02 ();
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

      public class PeEstado_flow02 : GXSubfileFlow
      {
         wpeestado _sf ;

         public PeEstado_flow02( wpeestado uType ) : base()
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
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer02( )
      {
         subwpeestado02 oAux = subwpeestado02 ;
         subwpeestado02 = new subwpeestado02 ();
         variablesToSubfile02 ();
         subGxsf2.addElement(subwpeestado02);
         subwpeestado02 = oAux;
      }

      private void E11V092( )
      {
         /* Load Routine */
         AV6Excluir = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV5Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV9Visuali = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf2.loadCommand();
      }

      protected void closeCursors02( )
      {
         pr_default.close(0);
      }

      protected void E12V092( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new testado(context, base.remoteHandle, base.context).execute(  A24EstCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E13V092( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new testado(context, base.remoteHandle, base.context).execute(  A24EstCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E14V092( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new testado(context, base.remoteHandle, base.context).execute(  A24EstCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E15V092( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new testado(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 700 , 768 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavEstuf = new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),63, 72, 24, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.CHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 63 , 72 , 24 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7EstUF" );
         ((GXEdit) edtavEstuf.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavEstuf.addFocusListener(this);
         edtavEstuf.getGXComponent().setHelpId("HLP_WPeEstado.htm");
         edtavEstnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),154, 72, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 154 , 72 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV8EstNome" );
         ((GXEdit) edtavEstnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavEstnome.addFocusListener(this);
         edtavEstnome.getGXComponent().setHelpId("HLP_WPeEstado.htm");
         addSubfile ( subGxsf2  = new GXSubfile ( new PeEstado_load02(this), new PeEstado_flow02(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 21 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV9Visuali" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 21 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 23 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV5Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 23 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 24 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV6Excluir" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 24 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 176, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 175 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" ), "Código do Estado"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 175 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , false )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(2, "XX", UIFactory.getFont( "Courier New", 0, 9),0, 0, 59, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.CHAR, false, false, 0, false) , null ,  0 , 0 , 58 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A25EstUF" ), "UF"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 58 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 441, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 440 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A12EstNome" ), "Estado"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 440 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 35 , 18 , GXPanel1 , 35 , 96 , 627 , 648 ,  18 ));
         subGxsf2.addActionListener(this);
         subGxsf2.addFocusListener(this);
         subGxsf2.setSortOnClick(true);
         subGxsf2.getColumn(0).addActionListener( this);
         subGxsf2.getColumn(0).addItemListener( this);
         subGxsf2.getColumn(1).addActionListener( this);
         subGxsf2.getColumn(1).addItemListener( this);
         subGxsf2.getColumn(2).addActionListener( this);
         subGxsf2.getColumn(2).addItemListener( this);
         bttbtt11 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  532 ,  72 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt11.setTooltip("Novo");
         bttbtt11.addActionListener(this);
         bttbtt11.setFiresEvents(false);
         lbllbl14 = UIFactory.getLabel(GXPanel1, "Cadastro de Estados", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 35 , 24 , 118 , 13 );
         lbllbl10 = UIFactory.getLabel(GXPanel1, "UF", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 35 , 72 , 17 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Estado", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 105 , 72 , 40 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavEstuf ,
                   edtavEstnome ,
                   subGxsf2 ,
                   bttbtt11
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
         subwpeestado02.setVVisualizar(AV9Visuali);
         subwpeestado02.setVEditar(AV5Editar);
         subwpeestado02.setVExcluir(AV6Excluir);
         subwpeestado02.setEstCodigo(A24EstCodi);
         subwpeestado02.setEstUF(A25EstUF);
         subwpeestado02.setEstNome(A12EstNome);
      }

      protected void subfileToVariables02( )
      {
         AV9Visuali = subwpeestado02.getVVisualizar();
         AV5Editar = subwpeestado02.getVEditar();
         AV6Excluir = subwpeestado02.getVExcluir();
         A24EstCodi = subwpeestado02.getEstCodigo();
         A25EstUF = subwpeestado02.getEstUF();
         A12EstNome = subwpeestado02.getEstNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavEstuf.setValue( AV7EstUF );
         edtavEstnome.setValue( AV8EstNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV7EstUF = (String)(edtavEstuf.getValue()) ;
         edtavEstuf.setValue(AV7EstUF);
         AV8EstNome = (String)(edtavEstnome.getValue()) ;
         edtavEstnome.setValue(AV8EstNome);
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
            subwpeestado02 = ( subwpeestado02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpeestado02 = new subwpeestado02 ();
         }
         subfileToVariables02 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile02 ();
         subGxsf2.refreshLineValue(subwpeestado02);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf2.inValidElement() )
         {
            subwpeestado02 = ( subwpeestado02 ) subGxsf2.getCurrentElement() ;
         }
         else
         {
            subwpeestado02 = new subwpeestado02 ();
         }
         subfileToVariables02 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt11.isEventSource(eventSource) ) {
            /* Execute user event: E15V092 */
            E15V092 ();
            return;
         }
         if ( subGxsf2.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf2.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E12V092 */
            E12V092 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E13V092 */
            E13V092 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E14V092 */
            E14V092 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
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
         if ( edtavEstuf.isEventSource(eventSource) ) {
            AV7EstUF = edtavEstuf.getValue() ;
            return;
         }
         if ( edtavEstnome.isEventSource(eventSource) ) {
            AV8EstNome = edtavEstnome.getValue() ;
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
            /* Execute user event: E12V092 */
            E12V092 ();
            return;
         }
         if ( subGxsf2.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V092 */
            E13V092 ();
            return;
         }
         if ( subGxsf2.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V092 */
            E14V092 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
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
         }
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
         subwpeestado02 = new subwpeestado02();
         scmdbuf = "" ;
         AV8EstNome = "" ;
         AV7EstUF = "" ;
         A12EstNome = "" ;
         A25EstUF = "" ;
         W00092_A12EstNome = new String[] {""} ;
         W00092_n12EstNome = new bool[] {false} ;
         W00092_A25EstUF = new String[] {""} ;
         W00092_n25EstUF = new bool[] {false} ;
         W00092_A24EstCodi = new int[1] ;
         n12EstNome = false ;
         n25EstUF = false ;
         A24EstCodi = 0 ;
         gxIsRefreshing = false ;
         AV6Excluir = "" ;
         AV5Editar = "" ;
         AV9Visuali = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpeestado__default(),
            new Object[][] {
                new Object[] {
               W00092_A12EstNome, W00092_n12EstNome, W00092_A25EstUF, W00092_n25EstUF, W00092_A24EstCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int A24EstCodi ;
      protected String scmdbuf ;
      protected String AV7EstUF ;
      protected String A25EstUF ;
      protected bool n12EstNome ;
      protected bool n25EstUF ;
      protected bool gxIsRefreshing ;
      protected String AV8EstNome ;
      protected String A12EstNome ;
      protected String AV6Excluir ;
      protected String AV5Editar ;
      protected String AV9Visuali ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpeestado02 subwpeestado02 ;
      protected IDataReader W00092 ;
      protected IDataStoreProvider pr_default ;
      protected String[] W00092_A12EstNome ;
      protected bool[] W00092_n12EstNome ;
      protected String[] W00092_A25EstUF ;
      protected bool[] W00092_n25EstUF ;
      protected int[] W00092_A24EstCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectString edtavEstuf ;
      protected GUIObjectString edtavEstnome ;
      protected GXSubfile subGxsf2 ;
      protected IGXButton bttbtt11 ;
      protected ILabel lbllbl14 ;
      protected ILabel lbllbl10 ;
      protected ILabel lbllbl9 ;
   }

   public class wpeestado__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W00092( String AV8EstNome ,
                                           String AV7EstUF ,
                                           String A12EstNome ,
                                           String A25EstUF )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [EstNome], [EstUF], [EstCodigo] FROM [ESTADO] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV8EstNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([EstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV8EstNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([EstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV8EstNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7EstUF).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([EstUF] = '" + StringUtil.RTrim( StringUtil.StringReplace( AV7EstUF, "'", "''")) + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([EstUF] = '" + StringUtil.RTrim( StringUtil.StringReplace( AV7EstUF, "'", "''")) + "')" ;
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
                     return conditional_W00092( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] );
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
          Object[] prmW00092 ;
          prmW00092 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W00092", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW00092,28,0,true,false )
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
