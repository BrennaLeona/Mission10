function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col subtitle text-center">
        <h1 className="text-white">{props.title}</h1>
        <p className="text-white">
          Learn about your favorite teams and bowlers!
        </p>
      </div>
    </header>
  );
}

export default Header;
