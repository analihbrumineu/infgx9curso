/*
               File: Gx00A0
        Description: Lista de Seleção Cadastro de astros.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/8/2026 9:5:20.29
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
   public class wgx00a0 : GXWorkpanel
   {
      public wgx00a0( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx00a0( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx00a0( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx00A0" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Cadastro de astros." ;
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
         return 599 ;
      }

      public override int getFrmHeight( )
      {
         return 258 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx00A0.htm";
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

      public void execute( out int aP0_pAstCodigo )
      {
         this.AV6pAstCod = 0 ;
         executePrivate();
         aP0_pAstCodigo=this.AV6pAstCod;
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
         subwgx00a008 = new subwgx00a008 ();
         /* Using cursor W002G2 */
         pr_default.execute(0, new Object[] {AV5cAstCod});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A113AstDat = W002G2_A113AstDat[0] ;
            n113AstDat = W002G2_n113AstDat[0] ;
            A49AstCodi = W002G2_A49AstCodi[0] ;
            /* Execute user event: E11V2G2 */
            E11V2G2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx00A0_load08 : GXLoadProducer
      {
         wgx00a0 _sf ;

         public Gx00A0_load08( wgx00a0 uType ) : base()
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
            subGrd_1.refresh();
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
         if (( (AV5cAstCod!=cV5cAstCod) ) || (!loadedFirstTime && ! isLoadAtStartup_flow08() )) {
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
         cV5cAstCod = AV5cAstCod ;
      }

      public void resetSearchConditions_flow08( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow08( )
      {
         return new subwgx00a008 ();
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

      public class Gx00A0_flow08 : GXSubfileFlow
      {
         wgx00a0 _sf ;

         public Gx00A0_flow08( wgx00a0 uType ) : base()
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
         /* End function GeneXus Refresh */
      }

      public override void GXEnter( )
      {
         /* Execute user event: E12V2G2 */
         E12V2G2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2G2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV6pAstCod = A49AstCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer08( )
      {
         subwgx00a008 oAux = subwgx00a008 ;
         subwgx00a008 = new subwgx00a008 ();
         variablesToSubfile08 ();
         subGrd_1.addElement(subwgx00a008);
         subwgx00a008 = oAux;
      }

      private void E11V2G2( )
      {
         /* Load Routine */
         subGrd_1.loadCommand();
      }

      protected void closeCursors08( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 0 , 0 , 599 , 258 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCastcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),196, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 196 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cAstCod" );
         ((GXEdit) edtavCastcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCastcodigo.addFocusListener(this);
         edtavCastcodigo.getGXComponent().setHelpId("HLP_WGx00A0.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx00A0_load08(this), new Gx00A0_flow08(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 161, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 160 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A49AstCodi" ), "Código do astro de cinema"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 160 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),0, 0, 235, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.DATE, false, false, 0, false) , null ,  0 , 0 , 234 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A113AstDat" ), "Data de nascimento do astro de cinema"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 234 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 48 , 452 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  491 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  491 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  491 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  491 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código do astro de cinema", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 152 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCastcodigo ,
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

      protected void variablesToSubfile08( )
      {
         subwgx00a008.setAstCodigo(A49AstCodi);
         subwgx00a008.setAstDatNascimento(A113AstDat);
      }

      protected void subfileToVariables08( )
      {
         A49AstCodi = subwgx00a008.getAstCodigo();
         A113AstDat = subwgx00a008.getAstDatNascimento();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCastcodigo.setValue( AV5cAstCod );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cAstCod = (int)(edtavCastcodigo.getValue()) ;
         edtavCastcodigo.setValue(AV5cAstCod);
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
            subwgx00a008 = ( subwgx00a008 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00a008 = new subwgx00a008 ();
         }
         subfileToVariables08 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile08 ();
         subGrd_1.refreshLineValue(subwgx00a008);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx00a008 = ( subwgx00a008 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx00a008 = new subwgx00a008 ();
         }
         subfileToVariables08 ();
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
            /* Execute user event: E12V2G2 */
            E12V2G2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2G2 */
            E12V2G2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCastcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCastcodigo.getGXCursor() );
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
         if ( edtavCastcodigo.isEventSource(eventSource) ) {
            AV5cAstCod = edtavCastcodigo.getValue() ;
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
            /* Execute user event: E12V2G2 */
            E12V2G2 ();
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
         this.AV6pAstCod = AV6pAstCod;
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
         subwgx00a008 = new subwgx00a008();
         scmdbuf = "" ;
         AV5cAstCod = 0 ;
         W002G2_A113AstDat = new DateTime[] {DateTime.MinValue} ;
         W002G2_n113AstDat = new bool[] {false} ;
         W002G2_A49AstCodi = new int[1] ;
         A113AstDat = (DateTime)(DateTime.MinValue) ;
         n113AstDat = false ;
         A49AstCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cAstCod = 0 ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx00a0__default(),
            new Object[][] {
                new Object[] {
               W002G2_A113AstDat, W002G2_n113AstDat, W002G2_A49AstCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5cAstCod ;
      protected int A49AstCodi ;
      protected int cV5cAstCod ;
      protected int AV6pAstCod ;
      protected String scmdbuf ;
      protected DateTime A113AstDat ;
      protected bool n113AstDat ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx00a008 subwgx00a008 ;
      protected IDataReader W002G2 ;
      protected IDataStoreProvider pr_default ;
      protected DateTime[] W002G2_A113AstDat ;
      protected bool[] W002G2_n113AstDat ;
      protected int[] W002G2_A49AstCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCastcodigo ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected int aP0_pAstCodigo ;
   }

   public class wgx00a0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW002G2 ;
          prmW002G2 = new Object[] {
          new Object[] {"@AV5cAstCod",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002G2", "SELECT [AstDatNascimento], [AstCodigo] FROM [ASTRO] WITH (NOLOCK) WHERE [AstCodigo] >= @AV5cAstCod ORDER BY [AstCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002G2,9,0,true,false )
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
                break;
       }
    }

 }

}
