/*
               File: Gx0080
        Description: Lista de Seleção Cadastro de cidades.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 11:31:34.26
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
   public class wgx0080 : GXWorkpanel
   {
      public wgx0080( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx0080( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx0080( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx0080" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Cadastro de cidades." ;
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
         return 546 ;
      }

      public override int getFrmHeight( )
      {
         return 282 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx0080.htm";
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

      public void execute( out int aP0_pCidCodigo )
      {
         this.AV7pCidCod = 0 ;
         executePrivate();
         aP0_pCidCodigo=this.AV7pCidCod;
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
         subwgx008010 = new subwgx008010 ();
         /* Using cursor W002F2 */
         pr_default.execute(0, new Object[] {AV5cCidCod, AV6cEstCod});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A24EstCodi = W002F2_A24EstCodi[0] ;
            n24EstCodi = W002F2_n24EstCodi[0] ;
            A26CidCodi = W002F2_A26CidCodi[0] ;
            /* Execute user event: E11V2F2 */
            E11V2F2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx0080_load10 : GXLoadProducer
      {
         wgx0080 _sf ;

         public Gx0080_load10( wgx0080 uType ) : base()
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
         if (( (AV5cCidCod!=cV5cCidCod)||(AV6cEstCod!=cV6cEstCod) ) || (!loadedFirstTime && ! isLoadAtStartup_flow10() )) {
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
         cV5cCidCod = AV5cCidCod ;
         cV6cEstCod = AV6cEstCod ;
      }

      public void resetSearchConditions_flow10( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow10( )
      {
         return new subwgx008010 ();
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

      public class Gx0080_flow10 : GXSubfileFlow
      {
         wgx0080 _sf ;

         public Gx0080_flow10( wgx0080 uType ) : base()
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
         /* Execute user event: E12V2F2 */
         E12V2F2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2F2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV7pCidCod = A26CidCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer10( )
      {
         subwgx008010 oAux = subwgx008010 ;
         subwgx008010 = new subwgx008010 ();
         variablesToSubfile10 ();
         subGrd_1.addElement(subwgx008010);
         subwgx008010 = oAux;
      }

      private void E11V2F2( )
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
         GXPanel1 = new GXPanel(this, 0 , 0 , 546 , 282 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCcidcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),210, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 210 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cCidCod" );
         ((GXEdit) edtavCcidcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCcidcodigo.addFocusListener(this);
         edtavCcidcodigo.getGXComponent().setHelpId("HLP_WGx0080.htm");
         edtavCestcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),210, 48, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 210 , 48 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cEstCod" );
         ((GXEdit) edtavCestcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCestcodigo.addFocusListener(this);
         edtavCestcodigo.getGXComponent().setHelpId("HLP_WGx0080.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx0080_load10(this), new Gx0080_flow10(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 171, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 170 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A26CidCodi" ), "Código da cidade da pessoa"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 170 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 172, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 171 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A24EstCodi" ), "Código do Estado da pessoa"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 171 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 72 , 399 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  438 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  438 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  438 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  438 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código da cidade da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 162 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Código do Estado da pessoa", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 163 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCcidcodigo ,
                   edtavCestcodigo ,
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
         subwgx008010.setCidCodigo(A26CidCodi);
         subwgx008010.setEstCodigo(A24EstCodi);
      }

      protected void subfileToVariables10( )
      {
         A26CidCodi = subwgx008010.getCidCodigo();
         A24EstCodi = subwgx008010.getEstCodigo();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCcidcodigo.setValue( AV5cCidCod );
         edtavCestcodigo.setValue( AV6cEstCod );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cCidCod = (int)(edtavCcidcodigo.getValue()) ;
         edtavCcidcodigo.setValue(AV5cCidCod);
         AV6cEstCod = (int)(edtavCestcodigo.getValue()) ;
         edtavCestcodigo.setValue(AV6cEstCod);
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
            subwgx008010 = ( subwgx008010 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx008010 = new subwgx008010 ();
         }
         subfileToVariables10 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile10 ();
         subGrd_1.refreshLineValue(subwgx008010);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx008010 = ( subwgx008010 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx008010 = new subwgx008010 ();
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
            /* Execute user event: E12V2F2 */
            E12V2F2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2F2 */
            E12V2F2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCcidcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCcidcodigo.getGXCursor() );
            return;
         }
         if ( edtavCestcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCestcodigo.getGXCursor() );
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
         if ( edtavCcidcodigo.isEventSource(eventSource) ) {
            AV5cCidCod = edtavCcidcodigo.getValue() ;
            return;
         }
         if ( edtavCestcodigo.isEventSource(eventSource) ) {
            AV6cEstCod = edtavCestcodigo.getValue() ;
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
            /* Execute user event: E12V2F2 */
            E12V2F2 ();
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
         this.AV7pCidCod = AV7pCidCod;
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
         subwgx008010 = new subwgx008010();
         scmdbuf = "" ;
         AV5cCidCod = 0 ;
         AV6cEstCod = 0 ;
         W002F2_A24EstCodi = new int[1] ;
         W002F2_n24EstCodi = new bool[] {false} ;
         W002F2_A26CidCodi = new int[1] ;
         A24EstCodi = 0 ;
         n24EstCodi = false ;
         A26CidCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cCidCod = 0 ;
         cV6cEstCod = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx0080__default(),
            new Object[][] {
                new Object[] {
               W002F2_A24EstCodi, W002F2_n24EstCodi, W002F2_A26CidCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5cCidCod ;
      protected int AV6cEstCod ;
      protected int A24EstCodi ;
      protected int A26CidCodi ;
      protected int cV5cCidCod ;
      protected int cV6cEstCod ;
      protected int AV7pCidCod ;
      protected String scmdbuf ;
      protected bool n24EstCodi ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx008010 subwgx008010 ;
      protected IDataReader W002F2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W002F2_A24EstCodi ;
      protected bool[] W002F2_n24EstCodi ;
      protected int[] W002F2_A26CidCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCcidcodigo ;
      protected GUIObjectInt edtavCestcodigo ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected int aP0_pCidCodigo ;
   }

   public class wgx0080__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW002F2 ;
          prmW002F2 = new Object[] {
          new Object[] {"@AV5cCidCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cEstCod",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002F2", "SELECT [EstCodigo], [CidCodigo] FROM [CIDADE] WITH (NOLOCK) WHERE ([CidCodigo] >= @AV5cCidCod) AND ([EstCodigo] >= @AV6cEstCod) ORDER BY [CidCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002F2,9,0,true,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
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
