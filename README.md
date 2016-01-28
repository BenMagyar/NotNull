# NotNull

[![Build status](https://ci.appveyor.com/api/projects/status/9yx8go451uql6kfv?svg=true)](https://ci.appveyor.com/project/BenMagyar/notnull)


A small library to help with nullable objects in C#.

# Object Extension Methods

List of methods with summaries and examples.

## `TOut IfNotNull<TIn, TOut>(this TIn item, Func<TIn, TOut> function)`

Returns `null` when `null`, otherwise it returns the output of the applied function.

```
string testObject = null;
testObject.IfNotNull(s => s + "llo");
>> null
testObject = "He";
testObject.IfNotNull(s => s + "llo");
>> "Hello"
```

## `TOut IfNotNullElseDefault<TIn, TOut>(this TIn item, Func<TIn, TOut> function)`

Returns `default` value of `TOut` when `null`, otherwise it
returns the output of the applied function.

```
string testObject = null;
testObject.IfNotNullElseDefault(s => s + "llo");
>> null
testObject = "He";
testObject.IfNotNullElseDefault(s => s + "llo");
>> "Hello"
```

## `void IfNotNull<TIn>(this TIn item, Action<TIn> action)`

Runs the action when not null.

```
string testObject = null;
// Will not run
testObject.IfNotNull(s => Console.WriteLine("Hello"));
```

## `TOut IfNotNullOrDefault<TIn, TOut>(this TIn item, Func<TIn, TOut> function)`

Returns default value of `TOut` when null or
default, otherwise it returns the output of the applied function.

```
int testObject = 0;
testObject.IfNotNullOrDefault(i => i + 5);
>> 0
testObject = 1;
testObject.IfNotNullOrDefault(i => i + 5);
>> 6
```

## `void IfNotNullOrDefault<TIn>(this TIn item, Action<TIn> action)`

Runs the action when not null or default

```
string testObject = "Hello";
// Will run
testObject.IfNotNullOrDefault(s => Console.WriteLine(s));
```

# Thanks
