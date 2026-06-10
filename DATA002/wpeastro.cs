/*
               File: PeAstro
        Description: Cadastro de astros.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 8:22:56.10
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
   public class wpeastro : GXWorkpanel
   {
      public wpeastro( int hnd ,
                       ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpeastro( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpeastro( IGxContext context ,
                       int hnd ,
                       ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeAstro" ;
      }

      public override String getFrmTitle( )
      {
         return "Cadastro de astros." ;
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
         return 728 ;
      }

      public override int getFrmHeight( )
      {
         return 766 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeAstro.htm";
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

      public void runLoad_load07( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpeastro07 = new subwpeastro07 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV5AstCodi ,
                                              AV6AstNome ,
                                              A49AstCodi ,
                                              A50AstNome ,
                                              AV11AstDat ,
                                              A114AstDat },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W001L2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf7.getSize() < 10000 ) ) )
         {
            A114AstDat = W001L2_A114AstDat[0] ;
            n114AstDat = W001L2_n114AstDat[0] ;
            A50AstNome = W001L2_A50AstNome[0] ;
            n50AstNome = W001L2_n50AstNome[0] ;
            A49AstCodi = W001L2_A49AstCodi[0] ;
            if ( ( AV11AstDat != 1 ) || ( ( A114AstDat != DateTimeUtil.CToD( "0", 2) ) ) )
            {
               /* Execute user event: E11V1L2 */
               E11V1L2 ();
            }
            pr_default.readNext(0);
         }
         if ( subGxsf7.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeAstro_load07 : GXLoadProducer
      {
         wpeastro _sf ;

         public PeAstro_load07( wpeastro uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer07();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load07();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors07();
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
            subGxsf7.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow07( )
      {
         return true;
      }

      public void autoRefresh_flow07( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV11AstDat!=cV11AstDat) ) || (!loadedFirstTime && ! isLoadAtStartup_flow07() )) {
            subfile.refresh();
            resetSubfileConditions_flow07() ;
         }
      }

      public bool getSearch_flow07( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow07( )
      {
         cV11AstDat = AV11AstDat ;
      }

      public void resetSearchConditions_flow07( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow07( )
      {
         return new subwpeastro07 ();
      }

      public bool getSearch_flow07( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow07( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow07( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow07( )
      {
         GXRefreshCommand07 ();
      }

      public class PeAstro_flow07 : GXSubfileFlow
      {
         wpeastro _sf ;

         public PeAstro_flow07( wpeastro uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow07();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow07(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow07();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow07();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow07(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow07();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow07(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow07(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow07(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow07();
         }

      }

      protected void GXRefreshCommand07( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer07( )
      {
         subwpeastro07 oAux = subwpeastro07 ;
         subwpeastro07 = new subwpeastro07 ();
         variablesToSubfile07 ();
         subGxsf7.addElement(subwpeastro07);
         subwpeastro07 = oAux;
      }

      private void E11V1L2( )
      {
         /* Load Routine */
         AV8Excluir = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV9Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV12Visual = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf7.loadCommand();
      }

      protected void closeCursors07( )
      {
         pr_default.close(0);
      }

      protected void E12V1L2( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new tastro(context, base.remoteHandle, base.context).execute(  A49AstCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E13V1L2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tastro(context, base.remoteHandle, base.context).execute(  A49AstCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E14V1L2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tastro(context, base.remoteHandle, base.context).execute(  A49AstCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E15V1L2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tastro(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 728 , 766 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavAstcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 80, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 80 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5AstCodi" );
         ((GXEdit) edtavAstcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavAstcodigo.addFocusListener(this);
         edtavAstcodigo.getGXComponent().setHelpId("HLP_WPeAstro.htm");
         edtavAstnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),143, 80, 286, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 143 , 80 , 286 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6AstNome" );
         ((GXEdit) edtavAstnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavAstnome.addFocusListener(this);
         edtavAstnome.getGXComponent().setHelpId("HLP_WPeAstro.htm");
         chkavAstdatfalecimento = new GUIObjectShort ( new GXCheckBox(GXPanel1, "Falecido?" , new java.lang.Short(1), new java.lang.Short(0)) , GXPanel1 , 442 , 82 , 84 , 17 , Integer.MAX_VALUE , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", IFontConstants.BOLD, 9) , true , "AV11AstDat" );
         chkavAstdatfalecimento.addFocusListener(this);
         chkavAstdatfalecimento.addItemListener(this);
         chkavAstdatfalecimento.getGXComponent().setHelpId("HLP_WPeAstro.htm");
         addSubfile ( subGxsf7  = new GXSubfile ( new PeAstro_load07(this), new PeAstro_flow07(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV12Visual" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV9Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV8Excluir" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 65, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 64 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A49AstCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 64 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 261, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 260 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A50AstNome" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 260 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 137, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 136 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A114AstDat" ), "Data de falecimento"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 136 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 33 , 18 , GXPanel1 , 65 , 117 , 599 , 624 ,  18 ));
         subGxsf7.addActionListener(this);
         subGxsf7.addFocusListener(this);
         subGxsf7.setSortOnClick(true);
         subGxsf7.getColumn(0).addActionListener( this);
         subGxsf7.getColumn(0).addItemListener( this);
         subGxsf7.getColumn(1).addActionListener( this);
         subGxsf7.getColumn(1).addItemListener( this);
         subGxsf7.getColumn(2).addActionListener( this);
         subGxsf7.getColumn(2).addItemListener( this);
         bttbtt14 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  546 ,  78 ,  78 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt14.setTooltip("Novo");
         bttbtt14.addActionListener(this);
         bttbtt14.setFiresEvents(false);
         lbllbl15 = UIFactory.getLabel(GXPanel1, "Cadastro de astros", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 107 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 143 , 65 , 33 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavAstcodigo ,
                   edtavAstnome ,
                   chkavAstdatfalecimento ,
                   subGxsf7 ,
                   bttbtt14
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf7, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile07( )
      {
         subwpeastro07.setVVisualizar(AV12Visual);
         subwpeastro07.setVEditar(AV9Editar);
         subwpeastro07.setVExcluir(AV8Excluir);
         subwpeastro07.setAstCodigo(A49AstCodi);
         subwpeastro07.setAstNome(A50AstNome);
         subwpeastro07.setAstDatFalecimento(A114AstDat);
      }

      protected void subfileToVariables07( )
      {
         AV12Visual = subwpeastro07.getVVisualizar();
         AV9Editar = subwpeastro07.getVEditar();
         AV8Excluir = subwpeastro07.getVExcluir();
         A49AstCodi = subwpeastro07.getAstCodigo();
         A50AstNome = subwpeastro07.getAstNome();
         A114AstDat = subwpeastro07.getAstDatFalecimento();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavAstcodigo.setValue( AV5AstCodi );
         edtavAstnome.setValue( AV6AstNome );
         chkavAstdatfalecimento.setValue( AV11AstDat );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5AstCodi = (int)(edtavAstcodigo.getValue()) ;
         edtavAstcodigo.setValue(AV5AstCodi);
         AV6AstNome = (String)(edtavAstnome.getValue()) ;
         edtavAstnome.setValue(AV6AstNome);
         AV11AstDat = (short)(chkavAstdatfalecimento.getValue()) ;
         chkavAstdatfalecimento.setValue(AV11AstDat);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf7.inValidElement() )
         {
            subwpeastro07 = ( subwpeastro07 ) subGxsf7.getCurrentElement() ;
         }
         else
         {
            subwpeastro07 = new subwpeastro07 ();
         }
         subfileToVariables07 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile07 ();
         subGxsf7.refreshLineValue(subwpeastro07);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf7.inValidElement() )
         {
            subwpeastro07 = ( subwpeastro07 ) subGxsf7.getCurrentElement() ;
         }
         else
         {
            subwpeastro07 = new subwpeastro07 ();
         }
         subfileToVariables07 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt14.isEventSource(eventSource) ) {
            /* Execute user event: E15V1L2 */
            E15V1L2 ();
            return;
         }
         if ( subGxsf7.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf7.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E12V1L2 */
            E12V1L2 ();
            return;
         }
         if ( subGxsf7.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E13V1L2 */
            E13V1L2 ();
            return;
         }
         if ( subGxsf7.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E14V1L2 */
            E14V1L2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavAstcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavAstcodigo.getGXCursor() );
            return;
         }
         if ( edtavAstnome.isEventSource(eventSource) ) {
            setGXCursor( edtavAstnome.getGXCursor() );
            return;
         }
         if ( chkavAstdatfalecimento.isEventSource(eventSource) ) {
            setGXCursor( chkavAstdatfalecimento.getGXCursor() );
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
         if ( edtavAstcodigo.isEventSource(eventSource) ) {
            AV5AstCodi = edtavAstcodigo.getValue() ;
            return;
         }
         if ( edtavAstnome.isEventSource(eventSource) ) {
            AV6AstNome = edtavAstnome.getValue() ;
            return;
         }
         if ( chkavAstdatfalecimento.isEventSource(eventSource) ) {
            AV11AstDat = chkavAstdatfalecimento.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf7.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E12V1L2 */
            E12V1L2 ();
            return;
         }
         if ( subGxsf7.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V1L2 */
            E13V1L2 ();
            return;
         }
         if ( subGxsf7.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V1L2 */
            E14V1L2 ();
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
         subwpeastro07 = new subwpeastro07();
         scmdbuf = "" ;
         AV5AstCodi = 0 ;
         AV6AstNome = "" ;
         A49AstCodi = 0 ;
         A50AstNome = "" ;
         AV11AstDat = 0 ;
         A114AstDat = (DateTime)(DateTime.MinValue) ;
         W001L2_A114AstDat = new DateTime[] {DateTime.MinValue} ;
         W001L2_n114AstDat = new bool[] {false} ;
         W001L2_A50AstNome = new String[] {""} ;
         W001L2_n50AstNome = new bool[] {false} ;
         W001L2_A49AstCodi = new int[1] ;
         n114AstDat = false ;
         n50AstNome = false ;
         gxIsRefreshing = false ;
         cV11AstDat = 0 ;
         AV8Excluir = "" ;
         AV9Editar = "" ;
         AV12Visual = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpeastro__default(),
            new Object[][] {
                new Object[] {
               W001L2_A114AstDat, W001L2_n114AstDat, W001L2_A50AstNome, W001L2_n50AstNome, W001L2_A49AstCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV11AstDat ;
      protected short cV11AstDat ;
      protected int AV5AstCodi ;
      protected int A49AstCodi ;
      protected String scmdbuf ;
      protected DateTime A114AstDat ;
      protected bool n114AstDat ;
      protected bool n50AstNome ;
      protected bool gxIsRefreshing ;
      protected String AV6AstNome ;
      protected String A50AstNome ;
      protected String AV8Excluir ;
      protected String AV9Editar ;
      protected String AV12Visual ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpeastro07 subwpeastro07 ;
      protected IDataReader W001L2 ;
      protected IDataStoreProvider pr_default ;
      protected DateTime[] W001L2_A114AstDat ;
      protected bool[] W001L2_n114AstDat ;
      protected String[] W001L2_A50AstNome ;
      protected bool[] W001L2_n50AstNome ;
      protected int[] W001L2_A49AstCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavAstcodigo ;
      protected GUIObjectString edtavAstnome ;
      protected GUIObjectShort chkavAstdatfalecimento ;
      protected GXSubfile subGxsf7 ;
      protected IGXButton bttbtt14 ;
      protected ILabel lbllbl15 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl4 ;
   }

   public class wpeastro__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W001L2( int AV5AstCodi ,
                                           String AV6AstNome ,
                                           int A49AstCodi ,
                                           String A50AstNome ,
                                           short AV11AstDat ,
                                           DateTime A114AstDat )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [AstDatFalecimento], [AstNome], [AstCodigo] FROM [ASTRO] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ( AV5AstCodi != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([AstCodigo] = " + StringUtil.Str( (decimal)(AV5AstCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([AstCodigo] = " + StringUtil.Str( (decimal)(AV5AstCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV6AstNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([AstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6AstNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([AstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6AstNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY [AstCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W001L2( (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (DateTime)dynConstraints[5] );
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
          Object[] prmW001L2 ;
          prmW001L2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W001L2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW001L2,27,0,true,false )
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
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
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
