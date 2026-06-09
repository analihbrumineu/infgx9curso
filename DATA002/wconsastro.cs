/*
               File: ConsAstro
        Description: Consulta de astros.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 8:48:41.15
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
   public class wconsastro : GXWorkpanel
   {
      public wconsastro( int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconsastro( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconsastro( IGxContext context ,
                         int hnd ,
                         ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsAstro" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de astros." ;
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
         return 689 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsAstro.htm";
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

      public void execute( out int aP0_AstCodigoRet )
      {
         this.AV5AstCodi = 0 ;
         executePrivate();
         aP0_AstCodigoRet=this.AV5AstCodi;
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
         subwconsastro07 = new subwconsastro07 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV12AstCod ,
                                              AV9AstNome ,
                                              A49AstCodi ,
                                              A50AstNome ,
                                              AV13AstDat ,
                                              A114AstDat },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W001M2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf7.getSize() < 10000 ) ) )
         {
            A114AstDat = W001M2_A114AstDat[0] ;
            n114AstDat = W001M2_n114AstDat[0] ;
            A50AstNome = W001M2_A50AstNome[0] ;
            n50AstNome = W001M2_n50AstNome[0] ;
            A49AstCodi = W001M2_A49AstCodi[0] ;
            if ( ( AV13AstDat != 1 ) || ( ( A114AstDat != DateTimeUtil.CToD( "0", 2) ) ) )
            {
               /* Execute user event: E11V1M2 */
               E11V1M2 ();
            }
            pr_default.readNext(0);
         }
         if ( subGxsf7.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsAstro_load07 : GXLoadProducer
      {
         wconsastro _sf ;

         public ConsAstro_load07( wconsastro uType ) : base()
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
         if (( (AV13AstDat!=cV13AstDat) ) || (!loadedFirstTime && ! isLoadAtStartup_flow07() )) {
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
         cV13AstDat = AV13AstDat ;
      }

      public void resetSearchConditions_flow07( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow07( )
      {
         return new subwconsastro07 ();
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

      public class ConsAstro_flow07 : GXSubfileFlow
      {
         wconsastro _sf ;

         public ConsAstro_flow07( wconsastro uType ) : base()
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

      public override void GXExit( )
      {
         /* Execute user event: E12V1M2 */
         E12V1M2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E12V1M2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV5AstCodi = A49AstCodi ;
         edtavAstcodigoret.setValue(AV5AstCodi);
      }

      protected void E13V1M2( )
      {
         eventLevelContext();
         /* AstCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E14V1M2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A49AstCodi") )
         {
            new wconsastro(context, base.remoteHandle, base.context).execute( out  A49AstCodi) ;
            ((subwconsastro07)subGxsf7.getCurrentElement()).setAstCodigo(A49AstCodi);
            subGxsf7.refreshLineValue(subGxsf7.getSelectedElement());
            subGxsf7.repaint();
         }
         eventLevelResetContext();
      }

      public void loadToBuffer07( )
      {
         subwconsastro07 oAux = subwconsastro07 ;
         subwconsastro07 = new subwconsastro07 ();
         variablesToSubfile07 ();
         subGxsf7.addElement(subwconsastro07);
         subwconsastro07 = oAux;
      }

      private void E11V1M2( )
      {
         /* Load Routine */
         subGxsf7.loadCommand();
      }

      protected void closeCursors07( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 689 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavAstcodigoret = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 78, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 65 , 78 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV5AstCodi" );
         ((GXEdit) edtavAstcodigoret.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavAstcodigoret.addFocusListener(this);
         edtavAstcodigoret.getGXComponent().setHelpId("HLP_WConsAstro.htm");
         edtavAstnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 78, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 78 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9AstNome" );
         ((GXEdit) edtavAstnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavAstnome.addFocusListener(this);
         edtavAstnome.getGXComponent().setHelpId("HLP_WConsAstro.htm");
         chkavAstdatfalecimento = new GUIObjectShort ( new GXCheckBox(GXPanel1, "Falecido?" , new java.lang.Short(1), new java.lang.Short(0)) , GXPanel1 , 533 , 78 , 84 , 17 , Integer.MAX_VALUE , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", IFontConstants.BOLD, 9) , true , "AV13AstDat" );
         chkavAstdatfalecimento.addFocusListener(this);
         chkavAstdatfalecimento.addItemListener(this);
         chkavAstdatfalecimento.getGXComponent().setHelpId("HLP_WConsAstro.htm");
         addSubfile ( subGxsf7  = new GXSubfile ( new ConsAstro_load07(this), new ConsAstro_flow07(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 79, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 78 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A49AstCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 78 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 334, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 333 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A50AstNome" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 333 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 103, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 102 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A114AstDat" ), "Falecimento"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 102 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 35 , 18 , GXPanel1 , 65 , 104 , 572 , 663 ,  18 ));
         subGxsf7.addActionListener(this);
         subGxsf7.addFocusListener(this);
         subGxsf7.setSortOnClick(true);
         subGxsf7.getColumn(0).addActionListener( this);
         subGxsf7.getColumn(0).addItemListener( this);
         lbllbl11 = UIFactory.getLabel(GXPanel1, "Consulta de astros", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 106 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 65 , 40 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Nome", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 65 , 33 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavAstcodigoret ,
                   edtavAstnome ,
                   chkavAstdatfalecimento ,
                   subGxsf7
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
         subwconsastro07.setAstCodigo(A49AstCodi);
         subwconsastro07.setAstNome(A50AstNome);
         subwconsastro07.setAstDatFalecimento(A114AstDat);
      }

      protected void subfileToVariables07( )
      {
         A49AstCodi = subwconsastro07.getAstCodigo();
         A50AstNome = subwconsastro07.getAstNome();
         A114AstDat = subwconsastro07.getAstDatFalecimento();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavAstcodigoret.setValue( AV5AstCodi );
         edtavAstnome.setValue( AV9AstNome );
         chkavAstdatfalecimento.setValue( AV13AstDat );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5AstCodi = (int)(edtavAstcodigoret.getValue()) ;
         edtavAstcodigoret.setValue(AV5AstCodi);
         AV9AstNome = (String)(edtavAstnome.getValue()) ;
         edtavAstnome.setValue(AV9AstNome);
         AV13AstDat = (short)(chkavAstdatfalecimento.getValue()) ;
         chkavAstdatfalecimento.setValue(AV13AstDat);
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
            subwconsastro07 = ( subwconsastro07 ) subGxsf7.getCurrentElement() ;
         }
         else
         {
            subwconsastro07 = new subwconsastro07 ();
         }
         subfileToVariables07 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile07 ();
         subGxsf7.refreshLineValue(subwconsastro07);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf7.inValidElement() )
         {
            subwconsastro07 = ( subwconsastro07 ) subGxsf7.getCurrentElement() ;
         }
         else
         {
            subwconsastro07 = new subwconsastro07 ();
         }
         subfileToVariables07 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf7.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf7.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V1M2 */
            E13V1M2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavAstcodigoret.isEventSource(eventSource) ) {
            setGXCursor( edtavAstcodigoret.getGXCursor() );
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
         if ( edtavAstcodigoret.isEventSource(eventSource) ) {
            AV5AstCodi = edtavAstcodigoret.getValue() ;
            return;
         }
         if ( edtavAstnome.isEventSource(eventSource) ) {
            AV9AstNome = edtavAstnome.getValue() ;
            return;
         }
         if ( chkavAstdatfalecimento.isEventSource(eventSource) ) {
            AV13AstDat = chkavAstdatfalecimento.getValue() ;
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
            /* Execute user event: E13V1M2 */
            E13V1M2 ();
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
            /* Execute user event: E12V1M2 */
            E12V1M2 ();
         }
         this.AV5AstCodi = AV5AstCodi;
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
         subwconsastro07 = new subwconsastro07();
         scmdbuf = "" ;
         AV12AstCod = 0 ;
         AV9AstNome = "" ;
         A49AstCodi = 0 ;
         A50AstNome = "" ;
         AV13AstDat = 0 ;
         A114AstDat = (DateTime)(DateTime.MinValue) ;
         W001M2_A114AstDat = new DateTime[] {DateTime.MinValue} ;
         W001M2_n114AstDat = new bool[] {false} ;
         W001M2_A50AstNome = new String[] {""} ;
         W001M2_n50AstNome = new bool[] {false} ;
         W001M2_A49AstCodi = new int[1] ;
         n114AstDat = false ;
         n50AstNome = false ;
         gxIsRefreshing = false ;
         cV13AstDat = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconsastro__default(),
            new Object[][] {
                new Object[] {
               W001M2_A114AstDat, W001M2_n114AstDat, W001M2_A50AstNome, W001M2_n50AstNome, W001M2_A49AstCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV13AstDat ;
      protected short cV13AstDat ;
      protected int AV12AstCod ;
      protected int A49AstCodi ;
      protected int AV5AstCodi ;
      protected String scmdbuf ;
      protected DateTime A114AstDat ;
      protected bool n114AstDat ;
      protected bool n50AstNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV9AstNome ;
      protected String A50AstNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconsastro07 subwconsastro07 ;
      protected IDataReader W001M2 ;
      protected IDataStoreProvider pr_default ;
      protected DateTime[] W001M2_A114AstDat ;
      protected bool[] W001M2_n114AstDat ;
      protected String[] W001M2_A50AstNome ;
      protected bool[] W001M2_n50AstNome ;
      protected int[] W001M2_A49AstCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavAstcodigoret ;
      protected GUIObjectString edtavAstnome ;
      protected GUIObjectShort chkavAstdatfalecimento ;
      protected GXSubfile subGxsf7 ;
      protected ILabel lbllbl11 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl4 ;
      protected int aP0_AstCodigoRet ;
   }

   public class wconsastro__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W001M2( int AV12AstCod ,
                                           String AV9AstNome ,
                                           int A49AstCodi ,
                                           String A50AstNome ,
                                           short AV13AstDat ,
                                           DateTime A114AstDat )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [AstDatFalecimento], [AstNome], [AstCodigo] FROM [ASTRO] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ( AV12AstCod != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([AstCodigo] = " + StringUtil.Str( (decimal)(AV12AstCod), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([AstCodigo] = " + StringUtil.Str( (decimal)(AV12AstCod), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV9AstNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([AstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV9AstNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([AstNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV9AstNome, "'", "''")), 50, "%") + "')" ;
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
                     return conditional_W001M2( (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (DateTime)dynConstraints[5] );
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
          Object[] prmW001M2 ;
          prmW001M2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W001M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW001M2,28,0,true,false )
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
