/*
               File: Gx0030
        Description: Lista de Seleção Cadastro de filmes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 11:52:37.41
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
   public class wgx0030 : GXWorkpanel
   {
      public wgx0030( int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wgx0030( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wgx0030( IGxContext context ,
                      int hnd ,
                      ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Gx0030" ;
      }

      public override String getFrmTitle( )
      {
         return "Lista de Seleção Cadastro de filmes." ;
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
         return 658 ;
      }

      public override int getFrmHeight( )
      {
         return 282 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WGx0030.htm";
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

      public void execute( out int aP0_pFilCodigo )
      {
         this.AV7pFilCod = 0 ;
         executePrivate();
         aP0_pFilCodigo=this.AV7pFilCod;
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
         subwgx003010 = new subwgx003010 ();
         lV6cFilNom = StringUtil.PadR( StringUtil.RTrim( AV6cFilNom), 50, "%") ;
         /* Using cursor W002A2 */
         pr_default.execute(0, new Object[] {AV5cFilCod, lV6cFilNom});
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGrd_1.getSize() < 10000 ) ) )
         {
            A29FilNome = W002A2_A29FilNome[0] ;
            n29FilNome = W002A2_n29FilNome[0] ;
            A28FilCodi = W002A2_A28FilCodi[0] ;
            /* Execute user event: E11V2A2 */
            E11V2A2 ();
            pr_default.readNext(0);
         }
         if ( subGrd_1.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class Gx0030_load10 : GXLoadProducer
      {
         wgx0030 _sf ;

         public Gx0030_load10( wgx0030 uType ) : base()
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
         if (( (AV5cFilCod!=cV5cFilCod)||(String.CompareOrdinal(AV6cFilNom.TrimEnd(' '), cV6cFilNom.TrimEnd(' ') )!=0) ) || (!loadedFirstTime && ! isLoadAtStartup_flow10() )) {
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
         cV5cFilCod = AV5cFilCod ;
         cV6cFilNom = AV6cFilNom ;
      }

      public void resetSearchConditions_flow10( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow10( )
      {
         return new subwgx003010 ();
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

      public class Gx0030_flow10 : GXSubfileFlow
      {
         wgx0030 _sf ;

         public Gx0030_flow10( wgx0030 uType ) : base()
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
         /* Execute user event: E12V2A2 */
         E12V2A2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V2A2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV7pFilCod = A28FilCodi ;
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
         eventLevelResetContext();
      }

      public void loadToBuffer10( )
      {
         subwgx003010 oAux = subwgx003010 ;
         subwgx003010 = new subwgx003010 ();
         variablesToSubfile10 ();
         subGrd_1.addElement(subwgx003010);
         subwgx003010 = oAux;
      }

      private void E11V2A2( )
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
         GXPanel1 = new GXPanel(this, 0 , 0 , 658 , 282 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCfilcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),133, 24, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 133 , 24 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5cFilCod" );
         ((GXEdit) edtavCfilcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCfilcodigo.addFocusListener(this);
         edtavCfilcodigo.getGXComponent().setHelpId("HLP_WGx0030.htm");
         edtavCfilnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),133, 48, 360, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 133 , 48 , 360 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6cFilNom" );
         ((GXEdit) edtavCfilnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCfilnome.addFocusListener(this);
         edtavCfilnome.getGXComponent().setHelpId("HLP_WGx0030.htm");
         addSubfile ( subGrd_1  = new GXSubfile ( new Gx0030_load10(this), new Gx0030_flow10(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 97, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 96 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A28FilCodi" ), "Código do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 96 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 358, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 357 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A29FilNome" ), "Nome do filme"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 357 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 9 , 18 , GXPanel1 , 21 , 72 , 511 , 193 ,  18 ));
         subGrd_1.addActionListener(this);
         subGrd_1.addFocusListener(this);
         subGrd_1.setSortOnClick(true);
         bttBtn_enter = UIFactory.getGXButton( GXPanel1 , "Confirmar" ,  550 ,  24 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_enter.setTooltip("Confirmar");
         bttBtn_enter.addActionListener(this);
         bttBtn_cancel = UIFactory.getGXButton( GXPanel1 , "Fechar" ,  550 ,  52 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_cancel.setTooltip("Fechar");
         bttBtn_cancel.addActionListener(this);
         bttBtn_cancel.setFiresEvents(false);
         bttBtn_refresh = UIFactory.getGXButton( GXPanel1 , "Renovar" ,  550 ,  80 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_refresh.setTooltip("Renovar");
         bttBtn_refresh.addActionListener(this);
         bttBtn_refresh.setFiresEvents(false);
         bttBtn_help = UIFactory.getGXButton( GXPanel1 , "Ajuda" ,  550 ,  118 ,  89 ,  23 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttBtn_help.setTooltip("Ajuda");
         bttBtn_help.addActionListener(this);
         bttBtn_help.setFiresEvents(false);
         lbllbl7 = UIFactory.getLabel(GXPanel1, "Código do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 24 , 88 , 13 );
         lbllbl9 = UIFactory.getLabel(GXPanel1, "Nome do filme", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 21 , 48 , 81 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCfilcodigo ,
                   edtavCfilnome ,
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
         subwgx003010.setFilCodigo(A28FilCodi);
         subwgx003010.setFilNome(A29FilNome);
      }

      protected void subfileToVariables10( )
      {
         A28FilCodi = subwgx003010.getFilCodigo();
         A29FilNome = subwgx003010.getFilNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCfilcodigo.setValue( AV5cFilCod );
         edtavCfilnome.setValue( AV6cFilNom );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5cFilCod = (int)(edtavCfilcodigo.getValue()) ;
         edtavCfilcodigo.setValue(AV5cFilCod);
         AV6cFilNom = (String)(edtavCfilnome.getValue()) ;
         edtavCfilnome.setValue(AV6cFilNom);
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
            subwgx003010 = ( subwgx003010 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx003010 = new subwgx003010 ();
         }
         subfileToVariables10 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile10 ();
         subGrd_1.refreshLineValue(subwgx003010);
      }

      protected void reloadGridRow( )
      {
         if ( subGrd_1.inValidElement() )
         {
            subwgx003010 = ( subwgx003010 ) subGrd_1.getCurrentElement() ;
         }
         else
         {
            subwgx003010 = new subwgx003010 ();
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
            /* Execute user event: E12V2A2 */
            E12V2A2 ();
            return;
         }
         if ( subGrd_1.isEventSource(eventSource) ) {
            /* Execute user event: E12V2A2 */
            E12V2A2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCfilcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCfilcodigo.getGXCursor() );
            return;
         }
         if ( edtavCfilnome.isEventSource(eventSource) ) {
            setGXCursor( edtavCfilnome.getGXCursor() );
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
         if ( edtavCfilcodigo.isEventSource(eventSource) ) {
            AV5cFilCod = edtavCfilcodigo.getValue() ;
            return;
         }
         if ( edtavCfilnome.isEventSource(eventSource) ) {
            AV6cFilNom = edtavCfilnome.getValue() ;
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
            /* Execute user event: E12V2A2 */
            E12V2A2 ();
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
         this.AV7pFilCod = AV7pFilCod;
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
         subwgx003010 = new subwgx003010();
         scmdbuf = "" ;
         lV6cFilNom = "" ;
         AV6cFilNom = "" ;
         AV5cFilCod = 0 ;
         W002A2_A29FilNome = new String[] {""} ;
         W002A2_n29FilNome = new bool[] {false} ;
         W002A2_A28FilCodi = new int[1] ;
         A29FilNome = "" ;
         n29FilNome = false ;
         A28FilCodi = 0 ;
         gxIsRefreshing = false ;
         cV5cFilCod = 0 ;
         cV6cFilNom = "" ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wgx0030__default(),
            new Object[][] {
                new Object[] {
               W002A2_A29FilNome, W002A2_n29FilNome, W002A2_A28FilCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV5cFilCod ;
      protected int A28FilCodi ;
      protected int cV5cFilCod ;
      protected int AV7pFilCod ;
      protected String scmdbuf ;
      protected bool n29FilNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String lV6cFilNom ;
      protected String AV6cFilNom ;
      protected String A29FilNome ;
      protected String cV6cFilNom ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwgx003010 subwgx003010 ;
      protected IDataReader W002A2 ;
      protected IDataStoreProvider pr_default ;
      protected String[] W002A2_A29FilNome ;
      protected bool[] W002A2_n29FilNome ;
      protected int[] W002A2_A28FilCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCfilcodigo ;
      protected GUIObjectString edtavCfilnome ;
      protected GXSubfile subGrd_1 ;
      protected IGXButton bttBtn_enter ;
      protected IGXButton bttBtn_cancel ;
      protected IGXButton bttBtn_refresh ;
      protected IGXButton bttBtn_help ;
      protected ILabel lbllbl7 ;
      protected ILabel lbllbl9 ;
      protected int aP0_pFilCodigo ;
   }

   public class wgx0030__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW002A2 ;
          prmW002A2 = new Object[] {
          new Object[] {"@AV5cFilCod",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cFilNom",SqlDbType.VarChar,50,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002A2", "SELECT [FilNome], [FilCodigo] FROM [FILME] WITH (NOLOCK) WHERE ([FilCodigo] >= @AV5cFilCod) AND ([FilNome] like @AV6cFilNom) ORDER BY [FilCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002A2,9,0,true,false )
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
