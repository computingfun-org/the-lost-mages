public static class InputMain {

    private static Input main;

    public static void Create() {
        if(main == null) {
            main = new Input();
            main.Enable();
        }
    }

    public static Input Get() => main;

    public static Input GetOrCreate() {
        Create();
        return Get();
    }
}
