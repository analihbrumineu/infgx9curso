/*
               File: ConsCategoria
        Description: Consulta de categorias.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/12/2026 11:52:36.53
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
   public class wconscategoria : GXWorkpanel
   {
      public wconscategoria( int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wconscategoria( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wconscategoria( IGxContext context ,
                             int hnd ,
                             ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ConsCategoria" ;
      }

      public override String getFrmTitle( )
      {
         return "Consulta de categorias" ;
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
         return 469 ;
      }

      public override int getFrmHeight( )
      {
         return 842 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WConsCategoria.htm";
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

      public void execute( out int aP0_CatCodigoRet )
      {
         this.AV5CatCodi = 0 ;
         executePrivate();
         aP0_CatCodigoRet=this.AV5CatCodi;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load06( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwconscategoria06 = new subwconscategoria06 ();
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV6CatCodi ,
                                              AV7CatNome ,
                                              A32CatCodi ,
                                              A33CatNome },
                                              new int[] {
                                              TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         });
         /* Using cursor W000L2 */
         pr_default.execute(0);
         while ( ( (pr_default.getStatus(0) != 101) ) && ( ( subGxsf6.getSize() < 10000 ) ) )
         {
            A33CatNome = W000L2_A33CatNome[0] ;
            n33CatNome = W000L2_n33CatNome[0] ;
            A32CatCodi = W000L2_A32CatCodi[0] ;
            /* Execute user event: E11V0L2 */
            E11V0L2 ();
            pr_default.readNext(0);
         }
         if ( subGxsf6.getSize() >= 10000 && !(pr_default.getStatus(0) == 101) )
         {
            GXutil.msg( me(), (String)(localUtil.getMessages().getMessage("mlmax", new Object[]{ 10000})) );
         }
         pr_default.close(0);
      }

      public class ConsCategoria_load06 : GXLoadProducer
      {
         wconscategoria _sf ;

         public ConsCategoria_load06( wconscategoria uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer06();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load06();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors06();
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
            subGxsf6.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow06( )
      {
         return true;
      }

      public void autoRefresh_flow06( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow06() )) {
            subfile.refresh();
            resetSubfileConditions_flow06() ;
         }
      }

      public bool getSearch_flow06( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow06( )
      {
      }

      public void resetSearchConditions_flow06( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow06( )
      {
         return new subwconscategoria06 ();
      }

      public bool getSearch_flow06( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow06( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow06( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow06( )
      {
         GXRefreshCommand06 ();
      }

      public class ConsCategoria_flow06 : GXSubfileFlow
      {
         wconscategoria _sf ;

         public ConsCategoria_flow06( wconscategoria uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow06();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow06(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow06();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow06();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow06(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow06();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow06(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow06(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow06(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow06();
         }

      }

      protected void GXRefreshCommand06( )
      {
         ControlsToVariables();
         /* Execute user event: E12V0L2 */
         E12V0L2 ();
         /* End function GeneXus Refresh */
      }

      protected void E12V0L2( )
      {
         /* Refresh Routine */
         if ( ( AV6CatCodi < 0 ) )
         {
            GXutil.msg( me(), "Digite um código válido!" );
         }
      }

      public override void GXExit( )
      {
         /* Execute user event: E13V0L2 */
         E13V0L2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
            }
            if (true) return;
         }
      }

      protected void E13V0L2( )
      {
         eventLevelContext();
         /* Exit Routine */
         AV5CatCodi = A32CatCodi ;
      }

      protected void E14V0L2( )
      {
         eventLevelContext();
         /* CatCodigo_Click Routine */
         if (canCleanup()) {
            returnInSub = true;
            this.cleanup();
         }
         if (true) return;
      }

      protected void E15V0L2( )
      {
         eventLevelContext();
         /* 'Pesquisa' Routine */
         if ( GXCursor("A32CatCodi") )
         {
            new wconscategoria(context, base.remoteHandle, base.context).execute( out  A32CatCodi) ;
            ((subwconscategoria06)subGxsf6.getCurrentElement()).setCatCodigo(A32CatCodi);
            subGxsf6.refreshLineValue(subGxsf6.getSelectedElement());
            subGxsf6.repaint();
         }
         eventLevelResetContext();
      }

      public void loadToBuffer06( )
      {
         subwconscategoria06 oAux = subwconscategoria06 ;
         subwconscategoria06 = new subwconscategoria06 ();
         variablesToSubfile06 ();
         subGxsf6.addElement(subwconscategoria06);
         subwconscategoria06 = oAux;
      }

      private void E11V0L2( )
      {
         /* Load Routine */
         subGxsf6.loadCommand();
      }

      protected void closeCursors06( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 469 , 842 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavCatcodigo = new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),65, 78, 73, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.NUMERIC, false, true, UIFactory.getColor(5), false) , GXPanel1 , 65 , 78 , 73 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6CatCodi" );
         ((GXEdit) edtavCatcodigo.getGXComponent()).setAlignment(ILabelConstants.RIGHT);
         edtavCatcodigo.addFocusListener(this);
         edtavCatcodigo.getGXComponent().setHelpId("HLP_WConsCategoria.htm");
         edtavCatnome = new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),171, 78, 195, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 171 , 78 , 195 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7CatNome" );
         ((GXEdit) edtavCatnome.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavCatnome.addFocusListener(this);
         edtavCatnome.getGXComponent().setHelpId("HLP_WConsCategoria.htm");
         addSubfile ( subGxsf6  = new GXSubfile ( new ConsCategoria_load06(this), new ConsCategoria_flow06(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 79, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 78 , 18 , UIFactory.getColor(5) , UIFactory.getColor(255, 0, 0) , UIFactory.getFont( "Courier New", 0, 9) , false , "A32CatCodi" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 78 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 166, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 165 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "A33CatNome" ), "Categoria"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 165 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 38 , 18 , GXPanel1 , 65 , 112 , 301 , 703 ,  18 ));
         subGxsf6.addActionListener(this);
         subGxsf6.addFocusListener(this);
         subGxsf6.setSortOnClick(true);
         subGxsf6.getColumn(0).addActionListener( this);
         subGxsf6.getColumn(0).addItemListener( this);
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Código", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 60 , 40 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "Categoria", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 171 , 60 , 55 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavCatcodigo ,
                   edtavCatnome ,
                   subGxsf6
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf6, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile06( )
      {
         subwconscategoria06.setCatCodigo(A32CatCodi);
         subwconscategoria06.setCatNome(A33CatNome);
      }

      protected void subfileToVariables06( )
      {
         A32CatCodi = subwconscategoria06.getCatCodigo();
         A33CatNome = subwconscategoria06.getCatNome();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavCatcodigo.setValue( AV6CatCodi );
         edtavCatnome.setValue( AV7CatNome );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV6CatCodi = (int)(edtavCatcodigo.getValue()) ;
         edtavCatcodigo.setValue(AV6CatCodi);
         AV7CatNome = (String)(edtavCatnome.getValue()) ;
         edtavCatnome.setValue(AV7CatNome);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf6.inValidElement() )
         {
            subwconscategoria06 = ( subwconscategoria06 ) subGxsf6.getCurrentElement() ;
         }
         else
         {
            subwconscategoria06 = new subwconscategoria06 ();
         }
         subfileToVariables06 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile06 ();
         subGxsf6.refreshLineValue(subwconscategoria06);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf6.inValidElement() )
         {
            subwconscategoria06 = ( subwconscategoria06 ) subGxsf6.getCurrentElement() ;
         }
         else
         {
            subwconscategoria06 = new subwconscategoria06 ();
         }
         subfileToVariables06 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf6.isEventSource(eventSource) ) {
            return;
         }
         if ( subGxsf6.getColumn(0).isEventSource(eventSource) ) {
            /* Execute user event: E14V0L2 */
            E14V0L2 ();
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
            AV6CatCodi = edtavCatcodigo.getValue() ;
            return;
         }
         if ( edtavCatnome.isEventSource(eventSource) ) {
            AV7CatNome = edtavCatnome.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
         if ( subGxsf6.getColumn(0).isEventSource(eventSource) && modifier == MOUSE_LEFTCLICK ) {
            /* Execute user event: E14V0L2 */
            E14V0L2 ();
            return;
         }
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (keyCode == UIFactory.getKeyCodes().getF4()) {
            /* Execute user event: E15V0L2 */
            E15V0L2 ();
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
            /* Execute user event: E13V0L2 */
            E13V0L2 ();
         }
         this.AV5CatCodi = AV5CatCodi;
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
         subwconscategoria06 = new subwconscategoria06();
         scmdbuf = "" ;
         AV6CatCodi = 0 ;
         AV7CatNome = "" ;
         A32CatCodi = 0 ;
         A33CatNome = "" ;
         W000L2_A33CatNome = new String[] {""} ;
         W000L2_n33CatNome = new bool[] {false} ;
         W000L2_A32CatCodi = new int[1] ;
         n33CatNome = false ;
         gxIsRefreshing = false ;
         returnInSub = false ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wconscategoria__default(),
            new Object[][] {
                new Object[] {
               W000L2_A33CatNome, W000L2_n33CatNome, W000L2_A32CatCodi
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected int AV6CatCodi ;
      protected int A32CatCodi ;
      protected int AV5CatCodi ;
      protected String scmdbuf ;
      protected bool n33CatNome ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected String AV7CatNome ;
      protected String A33CatNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwconscategoria06 subwconscategoria06 ;
      protected IDataReader W000L2 ;
      protected IDataStoreProvider pr_default ;
      protected String[] W000L2_A33CatNome ;
      protected bool[] W000L2_n33CatNome ;
      protected int[] W000L2_A32CatCodi ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectInt edtavCatcodigo ;
      protected GUIObjectString edtavCatnome ;
      protected GXSubfile subGxsf6 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl5 ;
      protected int aP0_CatCodigoRet ;
   }

   public class wconscategoria__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected String conditional_W000L2( int AV6CatCodi ,
                                           String AV7CatNome ,
                                           int A32CatCodi ,
                                           String A33CatNome )
      {
         String sWhereString ;
         String scmdbuf ;
         scmdbuf = "SELECT [CatNome], [CatCodigo] FROM [CATEGORIA] WITH (NOLOCK)" ;
         sWhereString = "" ;
         if ( ( AV6CatCodi != 0 ) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([CatCodigo] = " + StringUtil.Str( (decimal)(AV6CatCodi), 9, 0) + ")" ;
            }
            else
            {
               sWhereString = sWhereString + " ([CatCodigo] = " + StringUtil.Str( (decimal)(AV6CatCodi), 9, 0) + ")" ;
            }
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( AV7CatNome).TrimEnd(' ') )==0)) )
         {
            if ( ( String.CompareOrdinal("".TrimEnd(' '), sWhereString.TrimEnd(' ') ) != 0 ) )
            {
               sWhereString = sWhereString + " and ([CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CatNome, "'", "''")), 50, "%") + "')" ;
            }
            else
            {
               sWhereString = sWhereString + " ([CatNome] like '" + StringUtil.PadR( StringUtil.RTrim( StringUtil.StringReplace( AV7CatNome, "'", "''")), 50, "%") + "')" ;
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
                     return conditional_W000L2( (int)dynConstraints[0] , (String)dynConstraints[1] , (int)dynConstraints[2] , (String)dynConstraints[3] );
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
          Object[] prmW000L2 ;
          prmW000L2 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000L2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000L2,30,0,true,false )
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
