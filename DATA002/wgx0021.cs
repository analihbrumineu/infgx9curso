/*
               File: Gx0021
        Description: Lista de Seleção Dependente
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:40:43.50
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
   public class wgx0021 : GXWorkpanel
   {
      public wgx0021( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx0021( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx0021( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx0021" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Dependente" ;
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
         return 374 ;
      }

      public override int getFrmHeight( )
      {
         return 282 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx0021.htm";
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

      public void execute( int aP0_PesCodigo ,
                           out int aP1_pPesDepCodigo )
      {
         this.A13PesCodi = aP0_PesCodigo;
         this.AV6pPesDep = 0 ;
         executePrivate();
         aP1_pPesDepCodigo=this.AV6pPesDep;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load10( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwgx002110 = new subwgx002110 ();
         /* Using cursor W00292 */
         pr_default.execute(0, new Object[] {A13PesCodi, AV5cPesDep});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A46PesDepC = W00292_A46PesDepC[0] ;
            /* Execute user event: E11V292 */
            E11V292 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx0021_load10 : GXLoadProducer
      {
         wgx0021 _sf ;

         public Gx0021_load10( wgx0021 uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer10();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load10();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors10();
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

      public bool isLoadAtStartup_flow10( )
      {
         return true;
      }

      public void autoRefresh_flow10( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( (AV5cPesDep!=cV5cPesDep) ) || (!loadedFirstTime && ! isLoadAtStartup_flow10() )) {
            subfile.refresh();
            resetSubfileConditions_flow10() ;
         }
      }

      public bool getSearch_flow10( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow10( )
      {
         cV5cPesDep = AV5cPesDep ;
      }

      public void resetSearchConditions_flow10( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow10( )
      {
         return new subwgx002110 ();
      }

      public bool getSearch_flow10( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow10( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow10( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow10( )
      {
         GXRefreshCommand10 ();
      }

      public class Gx0021_flow10 : GXSubfileFlow
      {
         wgx0021 _sf ;

         public Gx0021_flow10( wgx0021 uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow10();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow10(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow10();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow10();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow10(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow10();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow10(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow10(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow10(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow10();
         }

      }

      protected void GXRefreshCommand10( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V292 */
         E12V292 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V292( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV6pPesDep = A46PesDepC ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer10( )
      {
         subwgx002110 oAux = subwgx002110 ;
         subwgx002110 = new subwgx002110 ();
         variablesToSubfile10 ();
         subGrd_1.addElement(subwgx002110);
         subwgx002110 = oAux;
      }

      private void E11V292( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors10( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 374 , 282 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtPesCodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),175, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), true) , GXPanel1 , 175 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A13PesCodi" );
         ((GXEdit) edtPesCodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtPesCodigo.addFocusListener(this);
         edtPesCodigo.getGXComponent().setHelpId("HLP_WGx0021.htm");
         edtavCpesdepcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),175, 48, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 175 , 48 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cPesDep" );
         ((GXEdit) edtavCpesdepcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCpesdepcodigo.addFocusListener(this);
         edtavCpesdepcodigo.getGXComponent().setHelpId("HLP_WGx0021.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx0021_load10(this), new Gx0021_flow10(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 138, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 137 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A46PesDepC" ), "Código do dependente"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 137 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 72 , 194 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  266 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  266 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  266 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  266 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 102 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código do dependente", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 129 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtPesCodigo ,
                   edtavCpesdepcodigo ,
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

      protected void variablesToSubfile10( )
      {
         subwgx002110.setPesDepCodigo(A46PesDepC);
         subwgx002110.setPesCodigo(A13PesCodi);
      }

      protected void subfileToVariables10( )
      {
         A46PesDepC = subwgx002110.getPesDepCodigo();
         A13PesCodi = subwgx002110.getPesCodigo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtPesCodigo.setValue( A13PesCodi );
         edtavCpesdepcodigo.setValue( AV5cPesDep );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         A13PesCodi = (int)(edtPesCodigo.getValue()) ;
         edtPesCodigo.setValue(A13PesCodi);
         AV5cPesDep = (int)(edtavCpesdepcodigo.getValue()) ;
         edtavCpesdepcodigo.setValue(AV5cPesDep);
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
            subwgx002110 = ( subwgx002110 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx002110 = new subwgx002110 ();
         }
         subfileToVariables10 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile10 ();
         subGrd_1.refreshLineValue(subwgx002110);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx002110 = ( subwgx002110 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx002110 = new subwgx002110 ();
         }
         subfileToVariables10 ();
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
            /* Execute user event: E12V292 */
            E12V292 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V292 */
            E12V292 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            setGXCursor( edtPesCodigo.getGXCursor() );
            return;
         }
         if ( edtavCpesdepcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCpesdepcodigo.getGXCursor() );
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
         if ( edtPesCodigo.isEventSource(eventSource) ) {
            A13PesCodi = edtPesCodigo.getValue() ;
            return;
         }
         if ( edtavCpesdepcodigo.isEventSource(eventSource) ) {
            AV5cPesDep = edtavCpesdepcodigo.getValue() ;
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
            /* Execute user event: E12V292 */
            E12V292 ();
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
         this.AV6pPesDep = AV6pPesDep;
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
         subwgx002110 = new subwgx002110();
         scmdbuf = "" ;
         AV5cPesDep = 0 ;
         W00292_A13PesCodi = new int[1] ;
         W00292_A46PesDepC = new int[1] ;
         A46PesDepC = 0 ;
         gxIsRefreshing = false ;
         cV5cPesDep = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx0021__default(),
            new Object[][] {
                new Object[] {
               W00292_A13PesCodi, W00292_A46PesDepC
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int A13PesCodi ;
      protected int AV5cPesDep ;
      protected int A46PesDepC ;
      protected int cV5cPesDep ;
      protected int AV6pPesDep ;
      protected String scmdbuf ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx002110 subwgx002110 ;
      protected IDataReader W00292 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W00292_A13PesCodi ;
      protected int[] W00292_A46PesDepC ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtPesCodigo ;
      protected GUIObjectInt edtavCpesdepcodigo ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected int aP1_pPesDepCodigo ;
   }

   public class wgx0021__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW00292 ;
          prmW00292 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5cPesDep",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W00292", "SELECT [PesCodigo], [PesDepCodigo] FROM [CLIENTEDEPENDENTE] WITH (NOLOCK) WHERE [PesCodigo] = @PesCodigo and [PesDepCodigo] >= @AV5cPesDep ORDER BY [PesCodigo], [PesDepCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW00292,9,0,true,false )
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
                break;
       }
    }

 }

}
