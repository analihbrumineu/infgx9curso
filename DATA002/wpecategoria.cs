/*
               File: PeCategoria
        Description: Cadastro de categorias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 8:58:3.56
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
   public class wpecategoria : GXWorkpanel
   {
      public wpecategoria( int hnd ,
                           ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wpecategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wpecategoria( IGxContext context ,
                           int hnd ,
                           ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "PeCategoria" ;
      }

      public override String getFrmTitle( )
      {
         return "Categorias" ;
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
         return 650 ;
      }

      public override int getFrmHeight( )
      {
         return 780 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WPeCategoria.htm";
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

      public void runLoad_load04( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwpecategoria04 = new subwpecategoria04 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A33CatNome ,
                                              A32CatCodi ,
                                              AV6CatNome ,
                                              AV5CatCodi },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT
                                              }
         });
         /* Using cursor W000C2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf4.getSize() < 10000 ) ) )
         {
            A33CatNome = W000C2_A33CatNome[0] ;
            n33CatNome = W000C2_n33CatNome[0] ;
            A32CatCodi = W000C2_A32CatCodi[0] ;
            /* Execute user event: E11V0C2 */
            E11V0C2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf4.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class PeCategoria_load04 : GXLoadProducer
      {
         wpecategoria _sf ;

         public PeCategoria_load04( wpecategoria uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer04();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load04();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors04();
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
            subGxsf4.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow04( )
      {
         return true;
      }

      public void autoRefresh_flow04( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow04() )) {
            subfile.refresh();
            resetSubfileConditions_flow04() ;
         }
      }

      public bool getSearch_flow04( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow04( )
      {
      }

      public void resetSearchConditions_flow04( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow04( )
      {
         return new subwpecategoria04 ();
      }

      public bool getSearch_flow04( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow04( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow04( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow04( )
      {
         GXRefreshCommand04 ();
      }

      public class PeCategoria_flow04 : GXSubfileFlow
      {
         wpecategoria _sf ;

         public PeCategoria_flow04( wpecategoria uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow04();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow04(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow04();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow04();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow04(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow04();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow04(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow04(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow04(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow04();
         }

      }

      protected void GXRefreshCommand04( )
      {
         ControlsToVariables();
         /* Execute user event: E12V0C2 */
         E12V0C2 ();
         /* End function GeneXus Refresh */
      }

      protected void E12V0C2( )
      {
         /* Refresh Routine */
         if ( ( AV5CatCodi < 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
      }

      public void loadToBuffer04( )
      {
         subwpecategoria04 oAux = subwpecategoria04 ;
         subwpecategoria04 = new subwpecategoria04 ();
         variablesToSubfile04 ();
         subGxsf4.addElement(subwpecategoria04);
         subwpecategoria04 = oAux;
      }

      private void E11V0C2( )
      {
         /* Load Routine */
         AV8Excluir = "c:\\KB\\DATA002\\bin\\deleteIcon.jpg" ;
         AV7Editar = "c:\\KB\\DATA002\\bin\\editIcon.jpg" ;
         AV9Visuali = "c:\\KB\\DATA002\\bin\\visualizarIcon.jpg" ;
         subGxsf4.loadCommand();
      }

      protected void closeCursors04( )
      {
         pr_default.close(0);
      }

      protected void E13V0C2( )
      {
         eventLevelContext();
         /* Visualizar_Click Routine */
         new tcategoria(context, base.remoteHandle, base.context).execute(  A32CatCodi,  "DSP") ;
         eventLevelResetContext();
      }

      protected void E14V0C2( )
      {
         eventLevelContext();
         /* Editar_Click Routine */
         new tcategoria(context, base.remoteHandle, base.context).execute(  A32CatCodi,  "UPD") ;
         GXRefresh();
      }

      protected void E15V0C2( )
      {
         eventLevelContext();
         /* Excluir_Click Routine */
         new tcategoria(context, base.remoteHandle, base.context).execute(  A32CatCodi,  "DLT") ;
         GXRefresh();
      }

      protected void E16V0C2( )
      {
         eventLevelContext();
         /* 'Novo' Routine */
         new tcategoria(context, base.remoteHandle, base.context).execute(  0,  "INS") ;
         GXRefresh();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 650 , 780 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCatcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 67, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 67 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV5CatCodi" );
         ((GXEdit) edtavCatcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodigo.addFocusListener(this);
         edtavCatcodigo.getGXComponent().setHelpId("HLP_WPeCategoria.htm");
         edtavCatnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),156, 67, 286, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 156 , 67 , 286 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6CatNome" );
         ((GXEdit) edtavCatnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCatnome.addFocusListener(this);
         edtavCatnome.getGXComponent().setHelpId("HLP_WPeCategoria.htm");
         addSubfile ( subGxsf4  = new GXSubfile ( new PeCategoria_load04(this), new PeCategoria_flow04(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV9Visuali" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 25 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV7Editar" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 25 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new SubfileImage() , null ,  0 , 0 , 26 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV8Excluir" ), ""  , UIFactory.getColor(18) , UIFactory.getColor(15) , 26 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 76, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 75 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A32CatCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 75 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 309, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 308 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A33CatNome" ), "Categoria"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 308 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 35 , 18 , GXPanel1 , 65 , 117 , 521 , 650 ,  18 ));
         subGxsf4.addActionListener(this);
         subGxsf4.addFocusListener(this);
         subGxsf4.setSortOnClick(true);
         subGxsf4.getColumn(0).addActionListener( this);
         subGxsf4.getColumn(0).addItemListener( this);
         subGxsf4.getColumn(1).addActionListener( this);
         subGxsf4.getColumn(1).addItemListener( this);
         subGxsf4.getColumn(2).addActionListener( this);
         subGxsf4.getColumn(2).addItemListener( this);
         bttbtt10 = UIFactory.getGXButton( GXPanel1 , "Novo" ,  481 ,  65 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt10.setTooltip("Novo");
         bttbtt10.addActionListener(this);
         bttbtt10.setFiresEvents(false);
         lbllbl2 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 52 , 78 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 156 , 52 , 78 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCatcodigo ,
                   edtavCatnome ,
                   subGxsf4 ,
                   bttbtt10
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf4, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile04( )
      {
         subwpecategoria04.setVVisualizar(AV9Visuali);
         subwpecategoria04.setVEditar(AV7Editar);
         subwpecategoria04.setVExcluir(AV8Excluir);
         subwpecategoria04.setCatCodigo(A32CatCodi);
         subwpecategoria04.setCatNome(A33CatNome);
      }

      protected void subfileToVariables04( )
      {
         AV9Visuali = subwpecategoria04.getVVisualizar();
         AV7Editar = subwpecategoria04.getVEditar();
         AV8Excluir = subwpecategoria04.getVExcluir();
         A32CatCodi = subwpecategoria04.getCatCodigo();
         A33CatNome = subwpecategoria04.getCatNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCatcodigo.setValue( AV5CatCodi );
         edtavCatnome.setValue( AV6CatNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV5CatCodi = (int)(edtavCatcodigo.getValue()) ;
         edtavCatcodigo.setValue(AV5CatCodi);
         AV6CatNome = (String)(edtavCatnome.getValue()) ;
         edtavCatnome.setValue(AV6CatNome);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf4.inValidElement() )
         {
            subwpecategoria04 = ( subwpecategoria04 ) subGxsf4.getCurrentElement() ;
         }
         else
         {
            subwpecategoria04 = new subwpecategoria04 ();
         }
         subfileToVariables04 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile04 ();
         subGxsf4.refreshLineValue(subwpecategoria04);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf4.inValidElement() )
         {
            subwpecategoria04 = ( subwpecategoria04 ) subGxsf4.getCurrentElement() ;
         }
         else
         {
            subwpecategoria04 = new subwpecategoria04 ();
         }
         subfileToVariables04 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( bttbtt10.isEventSource(eventSource) ) {
            /* Execute user event: E16V0C2 */
            E16V0C2 ();
            return;
         }
         if ( subGxsf4.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf4.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E13V0C2 */
            E13V0C2 ();
            return;
         }
         if ( subGxsf4.getColumn(1).isEventSource(eventSource) ) {
            /* Execute user event: E14V0C2 */
            E14V0C2 ();
            return;
         }
         if ( subGxsf4.getColumn(2).isEventSource(eventSource) ) {
            /* Execute user event: E15V0C2 */
            E15V0C2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavCatcodigo.isEventSource(eventSource) ) {
            setGXCursor( edtavCatcodigo.getGXCursor() );
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            setGXCursor( edtavCatnome.getGXCursor() );
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
         if ( edtavCatcodigo.isEventSource(eventSource) ) {
            AV5CatCodi = edtavCatcodigo.getValue() ;
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            AV6CatNome = edtavCatnome.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf4.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E13V0C2 */
            E13V0C2 ();
            return;
         }
         if ( subGxsf4.getColumn(1).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0C2 */
            E14V0C2 ();
            return;
         }
         if ( subGxsf4.getColumn(2).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E15V0C2 */
            E15V0C2 ();
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
         subwpecategoria04 = new subwpecategoria04();
         scmdbuf = "" ;
         A33CatNome = "" ;
         A32CatCodi = 0 ;
         AV6CatNome = "" ;
         AV5CatCodi = 0 ;
         W000C2_A33CatNome = new String[] {""} ;
         W000C2_n33CatNome = new bool[] {false} ;
         W000C2_A32CatCodi = new int[1] ;
         n33CatNome = false ;
         gxIsRefreshing = false ;
         AV8Excluir = "" ;
         AV7Editar = "" ;
         AV9Visuali = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wpecategoria__default(),
            new Object[][] {
                new Object[] {
               W000C2_A33CatNome, W000C2_n33CatNome, W000C2_A32CatCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int A32CatCodi ;
      protected int AV5CatCodi ;
      protected String scmdbuf ;
      protected bool n33CatNome ;
      protected bool gxIsRefreshing ;
      protected String A33CatNome ;
      protected String AV6CatNome ;
      protected String AV8Excluir ;
      protected String AV7Editar ;
      protected String AV9Visuali ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwpecategoria04 subwpecategoria04 ;
      protected IDataReader W000C2 ;
      protected IDataStoreProvider pr_default ;
      protected String[] W000C2_A33CatNome ;
      protected bool[] W000C2_n33CatNome ;
      protected int[] W000C2_A32CatCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCatcodigo ;
      protected GUIObjectString edtavCatnome ;
      protected GXSubfile subGxsf4 ;
      protected IGXButton bttbtt10 ;
      protected ILabel lbllbl2 ;
      protected ILabel lbllbl3 ;
   }

   public class wpecategoria__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000C2( String A33CatNome ,
                                           int A32CatCodi ,
                                           String AV6CatNome ,
                                           int AV5CatCodi )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [CatNome], [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( A33CatNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6CatNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV6CatNome, "'", "''")), 50, "%") + "')" ;
            }
         }
         if ( ! ((0==A32CatCodi)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([CatCodigo] = " + StringUtil.Str( (decimal)(AV5CatCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([CatCodigo] = " + StringUtil.Str( (decimal)(AV5CatCodi), 9, 0) + ")" ;
            }
         }
         if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY [CatCodigo]" ;
         return scmdbuf;
      }

      public override String getDynamicStatement( int cursor ,
                                                  Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_W000C2( (String)dynConstraints[0] , (int)dynConstraints[1] , (String)dynConstraints[2] , (int)dynConstraints[3] );
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
          Object[] prmW000C2 ;
          prmW000C2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000C2,28,0,true,false )
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
       }
    }

 }

}
